using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resolutionscreen : MonoBehaviour
{
    public int width;
    public int height;
    
    public void setWidth(int newWidth) {
        width = newWidth;
    }
    public void setHeight(int newHeight) {

        height = newHeight;
    }
    public void SetRes() {
        Screen.SetResolution(width, height,false);
    }
    public void Back() {
        SceneManager.LoadScene("OptionMenu");
    }
}
