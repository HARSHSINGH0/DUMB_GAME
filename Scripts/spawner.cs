using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Spikes;
    public Vector3 spikespos;
    public Rigidbody2D rb;
    public float speed = -15f;
    void Start()
    {
        
        rb.velocity=new Vector2(0f,speed);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Destroyer") {
            transform.position = spikespos;
            
        }
        if (other.tag == "Collider") {
            spikespos = new Vector2(other.transform.position.x, other.transform.position.y);
        }
    }
}
