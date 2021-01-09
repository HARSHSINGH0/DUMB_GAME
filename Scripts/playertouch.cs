using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertouch : MonoBehaviour
{
    public Animator m_Animator;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Spikestouch")
        {
            m_Animator.SetTrigger("ifplayertouch");
        }
    }
}
