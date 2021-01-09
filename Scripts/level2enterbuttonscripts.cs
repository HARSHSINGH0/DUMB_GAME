using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2enterbuttonscripts : MonoBehaviour
{
    public Button enterButton;
    public level2enterbutton l2eb;
    Queue<string> dumb = new Queue<string>(5);
    public GameObject otd;
    
    private void Update()
    {
        if (dumb.Contains("d")) {
            if (dumb.Contains("u")) if (dumb.Contains("m")) if (dumb.Contains("b")) Destroy(otd);
        }
        if (Input.GetButtonDown("Enter"))
        {
            if (enterButton.interactable == true) {
                l2eb.enterButton();
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
            l2eb.openEntertrue = true;
            if (Input.GetButtonDown("Enter"))
            {
                l2eb.enterButton();
            }
        }
        if (other.tag == "d")
        {
            dumb.Enqueue("d");
        }
        if (other.tag == "u")
        {
            dumb.Enqueue("u");
        }
        if (other.tag == "m")
        {
            dumb.Enqueue("m");
        }
        if (other.tag == "b")
        {
            dumb.Enqueue("b");
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
            l2eb.openEntertrue = false;
        }
        
    }
}
