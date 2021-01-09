using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBlastscript : MonoBehaviour
{
    
    public ParticleSystem boxblast;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(BoxBlast());
            //Destroy(gameObject);
        }
    }
    public IEnumerator BoxBlast()
    {
        Boxblastingeffect();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
    void Boxblastingeffect()
    {
        boxblast.Play();
    }

}
