using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;

public class CheckpointController : MonoBehaviour
{
    public AudioManager audioManager;
    public Sprite buttonnotpressed;
    public Sprite buttonpressed;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();



    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            checkpointSpriteRenderer.sprite = buttonpressed;
            audioManager.Play("Checkpoint");
        }

    }
}
