using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public float sliderValue1;
    //private void Update()
    //{
    //    sliderValue1 = PlayerPrefs.GetFloat("sliderValue", sliderValue1);
    //    Setlevel(sliderValue1);//this is for when option menu restart it should save the prrvious stored value
    //    Debug.Log(sliderValue1);
    //}
    
    public void Setlevel(float sliderValue) {
        //sliderValue1 = sliderValue;
        mixer.SetFloat("MixerVolume", Mathf.Log10(sliderValue)*20);
    }
    public void SetlevelSFX(float sliderValue)
    {
        //sliderValue1 = sliderValue;
        mixer.SetFloat("sfxvolume", Mathf.Log10(sliderValue) * 20);
    }
}
