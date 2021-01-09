using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSystem : MonoBehaviour
{
    public PlayerController gameplayer;
    public GameObject player;
    public int respawnseconds;
    public Vector3 respawnpoint;
    public Rigidbody2D rigidBody;
    public Animator m_Anim;
    //public transform playerprefab;
    // start is called before the first frame update
    void start()
    {
        gameplayer = FindObjectOfType<PlayerController>();
        m_Anim = gameObject.GetComponent<Animator>();
    }

    // update is called once per frame
    void update()
    {

    }
    //public ienumerator respawncoroutine()
    //{
    //    gameplayer.gameobject.setactive(false);
    //    yield return new waitforseconds(respawnseconds);
    //    gameplayer.gameobject.setactive(true);
    //    transform.position = respawnpoint;
    //    //instantiate(playerprefab, respawnpoint.position, respawnpoint.rotation);
    //}

    

    public static void transrespawnplayer()
    {
        Debug.Log("transrespawnplayer");
        
    }
    

    IEnumerator respawncoroutines()
    {
        rigidBody.constraints = RigidbodyConstraints2D.FreezePosition;
        yield return new WaitForSeconds(respawnseconds);
        rigidBody.constraints = RigidbodyConstraints2D.None;
        StopCoroutine(respawncoroutines());
    }
}