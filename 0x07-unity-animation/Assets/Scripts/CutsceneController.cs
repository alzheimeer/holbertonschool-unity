using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camtwo;
    void Start()
    {
        camtwo = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")) camtwo.enabled = false;
        if (Input.GetKeyDown("z")) camtwo.enabled = true;

    }
}
