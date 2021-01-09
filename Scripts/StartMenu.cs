using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void PlayButton() {
        SceneManager.LoadScene("MainMenu");
    }
    public void OptionButton() {
        SceneManager.LoadScene("OptionMenu");
    }
    public void QuitGame()
    {
        
        Application.Quit();
    }
}
