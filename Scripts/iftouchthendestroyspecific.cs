using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftouchthendestroyspecific : MonoBehaviour
{
    public GameObject otd;
    public AudioManager audioManager;
    public ParticleSystem Deatheffect;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            audioManager.Play("enemydeath");
            Destroy(otd);
            DeathEffect();
        }
        
    }
    void DeathEffect()
    {

        Deatheffect.Play();
    }
}
