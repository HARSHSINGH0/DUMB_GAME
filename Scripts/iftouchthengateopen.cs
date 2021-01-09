using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftouchthengateopen : MonoBehaviour
{
    //public GameObject doorlock;
    public BoxCollider2D doorcollider;
    public AudioManager audioManager;
    private void Start()
    {
        doorcollider=doorcollider.GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {

            //doorcollider = doorlock.GetComponent<BoxCollider2D>();
            if (doorcollider.enabled == false) { 
                doorcollider.enabled = true;
                audioManager.Play("dooropen");
            }
        }
    }
   
}
