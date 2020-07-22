using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;


public class OptionsMenu : MonoBehaviour
{

    public Toggle inverted;
    public AudioMixer BGM;
    public AudioMixer SFX;

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Apply()
    {
        PlayerPrefs.SetString("Inverted", inverted.isOn.ToString());
    }
}