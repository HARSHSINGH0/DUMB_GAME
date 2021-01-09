using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int life=2;
    private LevelManager gameLevelManager;
    public AudioManager audioManager;
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            gameLevelManager.AddCoins(1);
            Destroy (gameObject);
            audioManager.Play("Coin");
        }
        
    }
}
