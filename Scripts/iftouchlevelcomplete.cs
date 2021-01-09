using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class iftouchlevelcomplete : MonoBehaviour
{
    public string levelname;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            SceneManager.LoadScene(levelname);
            Pass();
        }
        
    }
    public void Pass() {
        
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked")) {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);

        }
        
    }
}
