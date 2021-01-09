using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftouchthenactive2 : MonoBehaviour
{
    public GameObject ote;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            ote.SetActive(true);
        }
    }
}
