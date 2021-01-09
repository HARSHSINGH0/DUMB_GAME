using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
