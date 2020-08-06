using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botons : MonoBehaviour
{
    public Transform wha;
    public Transform git;
    public Transform you;
    public Transform twi;
    public Transform face;
    public Transform inst;


    public void botonP()
    {
        Button btn = wha.GetComponent<Button>();
        btn.onClick.AddListener(wharedir);

    }
    public void botongit()
    {
        Button btn = git.GetComponent<Button>();
        btn.onClick.AddListener(gitredir);

    }
    public void botonYou()
    {
        Button btn = you.GetComponent<Button>();
        btn.onClick.AddListener(youredir);

    }
    public void botonTwiter()
    {
        Button btn = twi.GetComponent<Button>();
        btn.onClick.AddListener(twiteredir);

    }
    public void botonFace()
    {
        Button btn = face.GetComponent<Button>();
        btn.onClick.AddListener(faceredir);

    }
    public void botonInstagram()
    {
        Button btn = inst.GetComponent<Button>();
        btn.onClick.AddListener(instaredir);

    }




    void wharedir()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=573193779313&text=%F0%9F%98%80");
    }

    void gitredir()
    {
        Application.OpenURL("https://github.com/alzheimeer");
    }

    void youredir()
    {
        Debug.Log("test");
        Application.OpenURL("https://www.youtube.com/channel/UCLVz3FqUU7R72VESQOL08sg");
    }

    void twiteredir()
    {
        Application.OpenURL("https://www.linkedin.com/in/alzheimeer/");
    }

    void faceredir()
    {
        Application.OpenURL("https://www.facebook.com/AIzheimeer/");
    }

    void instaredir()
    {
        Application.OpenURL("https://www.instagram.com/alzheimeer/");
    }
}
