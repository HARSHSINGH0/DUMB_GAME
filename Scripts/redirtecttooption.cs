using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class redirtecttooption : MonoBehaviour
{
    
    public void redirecttotoption()
    {
        SceneManager.LoadScene("video");
    }
    public void redirecttomainmenu() {
        SceneManager.LoadScene("MainMenu");
    }
}