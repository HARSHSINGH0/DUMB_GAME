using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockcollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ote;
    public GameObject rock;
    public GameObject platform;
    public AudioManager audioManager;
    public GameObject texttod;
    public GameObject texttod1;
    public GameObject texttod2;
    public GameObject coin;
    public GameObject key1;

    public GameObject key2;

    public GameObject key3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "rock") {
            ote.SetActive(true);
        }
    }
    private void Start()
    {
        StartCoroutine(waitfor10seconds());
    }
    IEnumerator waitfor10seconds()
    {
        yield return new WaitForSeconds(12f);
        rock.SetActive(true);
        audioManager.Play("woosh");
        yield return new WaitForSeconds(8f);
        Destroy(rock);
        audioManager.Play("woosh");
        Destroy(platform);
        yield return new WaitForSeconds(10f);//5f tha pehle
        Destroy(texttod);
        texttod1.SetActive(true);
        
        coin.SetActive(true);
        audioManager.Play("woosh");
        yield return new WaitForSeconds(10f);//4f tha pehle
        audioManager.Play("woosh");
        Destroy(coin);
        yield return new WaitForSeconds(5f);//1f tha
        audioManager.Play("woosh");
        key1.SetActive(true);

        key2.SetActive(true);

        key3.SetActive(true);
        yield return new WaitForSeconds(5f);//4f tha
        audioManager.Play("woosh");
        Destroy(key1);
        Destroy(key2);
        Destroy(key3);
        Destroy(texttod1);
        texttod2.SetActive(true);
    }
}

