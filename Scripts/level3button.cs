using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3button : MonoBehaviour
{

    public bool openEntertrue;
    public AudioManager audioManager;
    public PlayerController playerController;
    public void enterButton()
    {
        if (openEntertrue)
        {
            //this works on openEnter2
            //rb.position = ttp2.position;
            //player.death();

        }
        else
        {
            ////rb.position = ttp.position;
            //Debug.Log("Enter button");
            //player.death();
            //this works for openEnter
            
            playerController.death();
            audioManager.Play("switches");
            
        }
    }
}
