using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class travel : MonoBehaviour
{
    public GameObject objtotp;
    public Transform tploc;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            objtotp.transform.position = tploc.transform.position;

        }
    }
}
