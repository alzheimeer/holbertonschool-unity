using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botons : MonoBehaviour
{
    public AudioSource buttonSound;



    public void botonP()
    {
        buttonSound.Play();
        Invoke("wharedir", 1);

    }
    public void botongit()
    {
        buttonSound.Play();
        Invoke("gitredir", 1);

    }
    public void botonYou()
    {
        buttonSound.Play();
        Invoke("youredir", 1);

    }
    public void botonTwiter()
    {
        buttonSound.Play();
        Invoke("twiteredir", 1);

    }
    public void botonFace()
    {
        buttonSound.Play();
        Invoke("faceredir", 1);

    }
    public void botonInstagram()
    {
        buttonSound.Play();
        Invoke("instaredir", 1);

    }

    public void botonLinkedin()
    {
        buttonSound.Play();
        Invoke("linkedinredir", 1);

    }


    void wharedir()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=573193779313&text=%F0%9F%98%80");
    }

    void gitredir()
    {
        Application.OpenURL("https://github.com/alzheimeer/");
    }

    void youredir()
    {
        Debug.Log("test");
        Application.OpenURL("https://www.youtube.com/channel/UCLVz3FqUU7R72VESQOL08sg");
    }

    void twiteredir()
    {
        Application.OpenURL("https://twitter.com/Alzheimeer/");
    }

    void faceredir()
    {
        Application.OpenURL("https://www.facebook.com/AIzheimeer/");
    }

    void instaredir()
    {
        Application.OpenURL("https://www.instagram.com/alzheimeer/");
    }

    void linkedinredir()
    {
        Application.OpenURL("https://www.linkedin.com/in/alzheimeer/");
    }
}
