using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushbuttonlevel5 : MonoBehaviour
{
    public AudioManager audioManager;
    public Sprite changedsprite;
    public Sprite changedsprite2;
    private SpriteRenderer sr;
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player") {
            audioManager.Play("thwack");
            sr= gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = changedsprite;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            audioManager.Play("thwack");
            sr = gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = changedsprite2;
        }

    }
}