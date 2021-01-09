using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2enterbutton : MonoBehaviour
{
    public Transform ttp;
    public Transform ttp2;
    public Rigidbody2D rb;
    public bool openEntertrue;
    // Start is called before the first frame update
    
    public void enterButton() {
        if (openEntertrue)
        {
            rb.position = ttp2.position;
        }
        else { 
            rb.position = ttp.position;
        }
    }
}
