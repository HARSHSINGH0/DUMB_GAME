using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{

    int levelsUnlocked;
    public Button[] buttons;

    private void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 3);//3 is used as build index
        for (int i = 0; i < buttons.Length; i++)
        {
            
            if (i + 3 > levelsUnlocked) {
                buttons[i].interactable = false;
            }
        }
        //for (int i = 0; i < levelsUnlocked; i++)
        //{
        //    buttons[i].interactable = true;

        //}
    }
    public void resetLevels() {
        PlayerPrefs.SetInt("levelsUnlocked", 3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void FirstLevel() {
        SceneManager.LoadScene("level1");
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene("level2");
    }
    public void ThirdLevel()
    {
        SceneManager.LoadScene("level3");
    }
    public void FourthLevel()
    {
        SceneManager.LoadScene("level4");
    }
    public void FifthLevel()
    {
        SceneManager.LoadScene("level5");
    }
    public void StartMenu() {
        SceneManager.LoadScene("StartMenu");
    }

}
