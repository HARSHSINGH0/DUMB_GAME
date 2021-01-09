using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iffallthentransport : MonoBehaviour
{
    public GameObject objecttotransport;
    public GameObject place;
    public Vector3 placetotransport;
    // Start is called before the first frame update
    void Start()
    {
        placetotransport = place.transform.position;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            objecttotransport.transform.position=new Vector3(placetotransport.x,placetotransport.y,objecttotransport.transform.position.z);
        }
    }
}
