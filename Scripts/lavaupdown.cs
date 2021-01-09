using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaupdown : MonoBehaviour
{
    public Rigidbody2D lava;
    public Collider2D col1;
    public Collider2D col2;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        lava.velocity = new Vector2(0f, speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == col1) {
            lava.velocity = new Vector2(0f, -speed);
        }
        if (collision == col2) {
            lava.velocity = new Vector2(0f, speed);
        }
    }
}
