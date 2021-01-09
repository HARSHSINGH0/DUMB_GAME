using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class honeyenemy : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject text;
    private SpriteRenderer gameobjectsprite;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            text.SetActive(true);
            StartCoroutine(waitforsec());

            
        }
    }
    IEnumerator waitforsec() {
        gameobjectsprite = gameObject.GetComponent<SpriteRenderer>();
        gameobjectsprite.enabled = false;
        yield return new WaitForSeconds(1f);
        go1.SetActive(true);
        go2.SetActive(true);
        go3.SetActive(true);
        go4.SetActive(true);
    }
}
