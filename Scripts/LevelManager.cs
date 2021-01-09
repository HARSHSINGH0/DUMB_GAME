using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int life;
    public GameObject life1, life2, life3, gameOver;
    public GameObject Player;
    public int NumberOfLife;
    private Rigidbody2D rb;

    void Start()
    {
        life = NumberOfLife;
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(false);
        life3.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        
    }
    
    
    //public static void KillPlayer(GameObject player) {
    //    Destroy(player.gameObject);
    //}
    // Update is called once per frame
    void Update()
    {
        
        if (life > 3)
            life = 3;
        switch (life) {
            case 3:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                break;
            case 2:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                break;
            case 1:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                break;
            case 0:
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                rb = Player.GetComponent<Rigidbody2D>();
                rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                break;
                
        }


    }
    public void AddCoins(int numberOfCoins) {
        
        life += numberOfCoins;

    }
    public void RemoveCoins(int numberOfCoins) {
        life -= numberOfCoins;
    }
}
