using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level3enterbuttonscripts : MonoBehaviour
{
    public Button enterButton;
    public level3button l3eb;
    public PlayerController playerController;
    private void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (enterButton.interactable == true)
            {
                l3eb.enterButton();
                //Debug.Log("openEnterEnter");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "openEnter")
        {
            enterButton.interactable = true;

        }
        if (other.tag == "openEnter2")
        {
            enterButton.interactable = true;
            //pl2eb.openEntertrue = true;
            if (Input.GetButtonDown("Submit"))
            {
                //l2eb.enterButton();
            }
        }
        if (other.tag == "switchbutton") {
            Destroy(other);
            
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "openEnter")
        {
            enterButton.interactable = false;
        }
        if (other.tag == "openEnter2")
        {
            enterButton.interactable = false;
            //l2eb.openEntertrue = false;
        }

    }

}
