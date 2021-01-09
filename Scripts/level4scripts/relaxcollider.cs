using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relaxcollider : MonoBehaviour
{
    public GameObject lasers;
    public GameObject otd;
    //private void Start()
    //{
    //    lasers.gameObject.active = false;
    //}
    private void Start()
    {

        StartCoroutine(waitfor50seconds());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            //
            //lasers.GetComponent<SpriteRenderer>().enabled = true;
            lasers.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //
            StartCoroutine(waitfor2seconds(2f));
            //lasers.GetComponent<SpriteRenderer>().enabled = false;
            
        }
    } 
    IEnumerator waitfor2seconds(float seconds) {
        yield return new WaitForSeconds(seconds);
        lasers.SetActive(false);
    }
    IEnumerator waitfor50seconds()
    {
        yield return new WaitForSeconds(50f);//phele 34 tha
        Destroy(otd);

    }
}
