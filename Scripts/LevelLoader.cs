using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public int transitiontime = 1;
    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(1)) {
    //        LoadNextLevel();
    //    }
    //}
    //public void LoadNextLevel() {
    //    StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    //}
    public void LoadAnimationlevel(int levelindex) {
        StartCoroutine(LoadAnimation(levelindex));
    }
    //IEnumerator LoadLevel(int levelindex)
    //{
    //    play animation
    //    transition.SetTrigger("Start");
    //    wait
    //    yield return new WaitForSeconds(transitiontime);

    //    load scene
    //    SceneManager.LoadScene(levelindex);
    //}
    IEnumerator LoadAnimation(int levelindex) {
        //play animation
        transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(transitiontime);
        //load scene
        SceneManager.LoadScene(levelindex);
    }
}
