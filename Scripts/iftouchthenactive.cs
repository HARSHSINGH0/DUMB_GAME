using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftouchthenactive : MonoBehaviour
{
    public GameObject thisObject;
    public GameObject thisObject2;
    public GameObject thisObject3;
    public GameObject thisObject4;
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        thisObject.GetComponent<SpriteRenderer>().enabled=false;

        thisObject2.GetComponent<SpriteRenderer>().enabled = false;

        thisObject3.GetComponent<SpriteRenderer>().enabled = false;

        thisObject4.GetComponent<SpriteRenderer>().enabled = false;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            audioManager.Play("touch");
            thisObject.GetComponent<SpriteRenderer>().enabled = true;
            thisObject2.GetComponent<SpriteRenderer>().enabled = true;
            thisObject3.GetComponent<SpriteRenderer>().enabled = true;
            thisObject4.GetComponent<SpriteRenderer>().enabled = true;
            

        }
    }
}
