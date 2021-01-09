using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderwise : MonoBehaviour
{

    private string dumb;
    private string dumb2;
    private int length;
    public GameObject otd;
    public AudioManager audioManager;
    public CameraShake cameraShake;
    public GameObject Players_collider_whichisusedas_trigger;
    public GameObject ote;
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "d") {
            dumb += "d";
            
        }
        if (other.tag == "u")
        {
            dumb += "u";

        }
        if (other.tag == "m")
        {
            dumb += "m";

        }
        if (other.tag == "b")
        {
            dumb += "b";

        }
    }

    void Update() {
        length = dumb.Length;
        dumb2 = dumb.Substring((dumb.Length - 4), 4);

        //Debug.Log("dumb2 is "+dumb2);
        Debug.Log("dumb2 is " + dumb2);
        if (dumb2 == "dumb") {
            StartCoroutine(Otd());
        }
    }
    IEnumerator Otd() {
        
        audioManager.Play("PlayerDeath");
        camerashakefunc();
        yield return new WaitForSeconds(0.1f);
        ote.SetActive(true);
        Destroy(otd);
        Destroy(Players_collider_whichisusedas_trigger);
    }
    void camerashakefunc() {
        StartCoroutine(cameraShake.Shake(.50f,.05f));
    }
    //void u(string u) {
    //    if (u == "u") {
    //        m("m");
    //    }
    //}
    //void m(string m)
    //{
    //    if (m == "m")
    //    {
    //        b("b");
    //    }
    //}
    //void b(string b) {
    //    if (b == "b") {
    //        Debug.Log("Player touched all");
    //    }
    //}

}
