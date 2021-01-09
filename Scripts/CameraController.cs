using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        playerPosition=new Vector3(player.transform.position.x,transform.position.y,transform.position.z);//player transform is used getting 3d x axis (don't know what i am doing)
        //but camera now shows outer world too
        if(player.transform.localScale.x>0){
            playerPosition=new Vector3(playerPosition.x+offset,playerPosition.y,playerPosition.z);
        }
        else{
            playerPosition=new Vector3(playerPosition.x+offset,playerPosition.y,playerPosition.z);
        }
        transform.position=Vector3.Lerp(transform.position,playerPosition,offsetSmoothing*Time.deltaTime);


    }
}
