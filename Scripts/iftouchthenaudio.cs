using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class iftouchthenaudio : MonoBehaviour
{
    public AudioManager audioManager;
    public string audioname;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision detected");
        if (collision.tag == "Player") {
            audioManager.Play(audioname);
            Destroy(gameObject);
        }
    }
}
