using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private const string Tag = "GameController";

    // Start is called before the first frame update
    private float speed=10f;
    private float speedBTN = 10f;

    public ParticleSystem Dust;
    public ParticleSystem Deatheffect;

    private float movement=0f;
    private Rigidbody2D rigidBody;
    private float jumpSpeed=10f;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private Animator playerAnimator;

    private SpriteRenderer rigidRenderer;

    public CameraShake cameraShake;

    public Vector3 respawnpoint;
    public static LevelManager lm;
    public PlayerController gamePlayer;
    //public bool dontMove;
    //public bool moveLeft;
    //public float respawnSeconds=30f;
    private bool moveLeft = false;
    private bool moveRight = false;
    private bool moveUp = false;

    public int randomsound;

    public Button enterButton;
    public AudioManager audioManager;
    void Start()
    {
        Application.targetFrameRate = 90;
        rigidBody=GetComponent<Rigidbody2D>();
        playerAnimator=GetComponent<Animator>();
        //gamePlayer = FindObjectOfType<PlayerController>();
        //if (lm == null)
        //{
        //    lm = GameObject.FindGameObjectWithTag("LM").GetComponent<LevelManager>();

        //}
        //RespawnPlayer();
        rigidRenderer=rigidBody.GetComponent<SpriteRenderer>();
        enterButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis ("Horizontal");
        if (movement > 0f ) {
            //rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
            //transform.localScale=new Vector2(2f,2f);
            right();
            
        }
        else if (movement < 0f ) {
            //rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
            //transform.localScale = new Vector2(-2f, 2f);
            left();
            
        }
        else {
          rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
        }
        if(Input.GetButtonDown ("Jump")){
            JumpButton();
        }
        //if(Input.GetKeyDown (KeyCode.W) && isTouchingGround){
        // rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
        //}
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        if (moveLeft) {
            leftButton();
        }
        else if (moveRight) { rightButton(); }
        if (moveUp)
        {
            JumpButton();
        }
        playerAnimator.SetFloat("Speed",Mathf.Abs(rigidBody.velocity.x));
        playerAnimator.SetBool("OnGround",isTouchingGround);
    }
    //public void AllowMovement(bool movement1) {
    //    dontMove = false;
    //    moveLeft = movement1;
    //}
    //public void DontAllowMovement() {
    //    dontMove = true;
    //}
    public void jump()
    {
        CreateDust();
        audioManager.Play("Jump");
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis("Horizontal");
        if (isTouchingGround) { 
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }
    public void right()
    {
        CreateDust();
        //this shit took my 5 days
        speed = 10f;
        rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        //rigidBody.AddForce(transform.forward * speed, ForceMode2D.Force);
        transform.localScale = new Vector2(2f, 2f);
        if (isTouchingGround)
        {
            audioManager.Play("Walking");
        }

    }
    public void left()
    {
        CreateDust();
        speed = 10f;
        rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        transform.localScale = new Vector2(-2f, 2f);
        if (isTouchingGround)
        {
            audioManager.Play("Walking");
        }
    }
    public void rightButton()
    {
        CreateDust();
        //this shit took my 5 days
        speedBTN = 10f;
        //MaxSpeed = 10f;
        //acceleration = 10f;
        //deceleration = 10f;
        
        rigidBody.velocity = new Vector2(speedBTN /*+ acceleration) * Time.deltaTime*/, rigidBody.velocity.y);
        //rigidBody.AddForce(transform.forward * speed, ForceMode2D.Force);
        transform.localScale = new Vector2(2f, 2f);

        //if (speedBTN < -MaxSpeed)
        //{
        //    if (speedBTN > deceleration *Time.deltaTime)
        //        speedBTN = speedBTN- deceleration *Time.deltaTime;
        //    else if (speedBTN < -deceleration * Time.deltaTime)
        //        speedBTN = speedBTN + deceleration * Time.deltaTime;
        //    else
        //        speedBTN = 0;
        //}
        if (isTouchingGround)
        {
            audioManager.Play("Walking");
        }
    }
    public void leftButton()
    {
        speedBTN = 10f;
        CreateDust();
        //i put -speed because movement will always will be in -1 to 1 so why not do directly 
        rigidBody.velocity = new Vector2(-speedBTN, rigidBody.velocity.y);
        transform.localScale = new Vector2(-2f, 2f);
        if (isTouchingGround)
        {
            audioManager.Play("Walking");
        }

    }
    public void JumpButton() {
        /*
         if(Input.GetButtonDown ("Jump") && isTouchingGround){
         rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
        }
         */
        CreateDust();

        
        jumpSpeed = 10f;
        if (isTouchingGround) {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
            audioManager.Play("Jump");
        }
        
    }
    public void LeftBtnDown()
    {
        moveLeft = true;
    }
    public void LeftBtnUp()
    {
        moveLeft = false;
    }
    public void RightBtnDown()
    {
        moveRight = true;
    }
    public void RightBtnUp()
    {
        moveRight = false;
    }
    public void JumpButtonDown() {
        moveUp = true;

    }
    public void JumpButtonUP() {
        moveUp = false;
    }
    //public void leftButton()
    //{
    //    movement = Input.GetAxis("Horizontal");
    //    movement = 1f;
    //    //rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
    //    rigidBody.velocity=transform.right* speed;
    //    if (rigidBody.velocity.magnitude > 0) {
    //        rigidBody.velocity = transform.right * speed;
    //    }
    //    transform.localScale = new Vector2(2f, 2f);

    //}
    //public void rightButton()
    //{
    //    movement = Input.GetAxis("Horizontal");
    //    movement = -1f;
    //    //rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);

    //    transform.localScale = new Vector2(-2f, 2f);

    //}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Checkpoint")
        {
            //respawnpoint.position = other.transform.position;
            //respawnpoint.rotation = other.transform.rotation;
            respawnpoint = new Vector2(other.transform.position.x, other.transform.position.y);
        }
        if (other.tag == "Death")
        {
            
            death();
        }
        if (other.tag == "FallDetector")
        {
            
            death();
        }
        if (other.tag == "Spikes")
        {
            death();
        }
        
    }
    

    public void death()
    {
        LevelManager.life -= 1;
        audioManager.Play("PlayerDeath");
        randomsound = Random.Range(1, 4);
        switch (randomsound) {
            case 1:
                audioManager.Play("ohhnice");
                break;
            case 2:
                audioManager.Play("Stupid");
                break;
            case 3:
                audioManager.Play("haha");
                break;
            
        }
        //transform.position = respawnPoint.position;
        //Destroy(gameObject);
        RespawnPlayer();

    }
    public Transform playerPrefab;
    public void RespawnPlayer()
    {
        //RespawnSystem.transrespawnplayer();
        //StartCoroutine(RespawnCoroutine());
        //StopCoroutine(RespawnCoroutine());
        
        StartCoroutine(RespawnCoroutine());
        
        //DeathEffect();
        //transform.position = respawnpoint;

    }
    public IEnumerator RespawnCoroutine()
    {
        
        DeathEffect();
        DeathCameraShake();
        rigidBody.GetComponent<PolygonCollider2D>().enabled = false;
        rigidBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rigidRenderer.enabled = false;
        yield return new WaitForSeconds(1f);
        rigidBody.constraints = RigidbodyConstraints2D.None;
        rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        rigidBody.GetComponent<PolygonCollider2D>().enabled = true;
        rigidRenderer.enabled = true;
        transform.position = respawnpoint;

    }
    void DeathEffect() {
        
        Deatheffect.Play();
    }
    //public IEnumerator RespawnCoroutine()
    //{
    //    rigidBody.gameObject.SetActive(false);
    //    yield return new WaitForSeconds(respawnSeconds);
    //    rigidBody.gameObject.SetActive(true);

    //    //Instantiate(playerPrefab, respawnPoint.position, respawnPoint.rotation);
    //}
    void CreateDust() {
        Dust.Play();
    }
    void DeathCameraShake() {
        StartCoroutine(cameraShake.Shake(.50f,.4f));
    }

}
