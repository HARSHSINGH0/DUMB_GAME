using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploysprites : MonoBehaviour
{
    public GameObject spritePrefab;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds;
    public GameObject location;
    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spritewave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(spritePrefab) as GameObject;
        a.transform.position = new Vector2(location.transform.position.x, location.transform.position.y);
    }
    IEnumerator spritewave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
