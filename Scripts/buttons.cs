using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttons : MonoBehaviour
{

    public GameObject main;
    public GameObject menuback;
    public GameObject menubutton;
    public GameObject littleone;
    public GameObject slide;
    public GameObject favoriter;
    public GameObject eventk;
    public GameObject support;
    public GameObject guide;
    public GameObject install;
    void Start () {
		
	}
    public void buttonurl()
    {
        Application.OpenURL("http://www.swevent.net");
    }
    public
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))

        {
            main.GetComponent<Animator>().Rebind();
            menuback.GetComponent<Animator>().Rebind();
            menuback.SetActive(false);
            littleone.SetActive(false);
            menubutton.GetComponent<Animator>().Rebind();
            slide.GetComponent<Animator>().Rebind();
            favoriter.GetComponent<Animator>().Rebind();
            eventk.GetComponent<Animator>().Rebind();
            support.GetComponent<Animator>().Rebind();
            guide.GetComponent<Animator>().Rebind();
            install.GetComponent<Animator>().Rebind();

        }
    }
}
