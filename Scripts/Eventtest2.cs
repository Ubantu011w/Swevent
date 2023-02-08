using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eventtest2 : MonoBehaviour
{
    public RawImage Event;
    public GameObject beskrivning;
    public GameObject namn;
    public GameObject date;
    public GameObject adress;
    public GameObject time;
    public GameObject email;
    public GameObject ovrigt;
    public Text beskrivningimport;
    //public RawImage img;
    public string url = "https://i.imgur.com/qgsZ5rG.jpg";
    public string man;
    public string txt;
    public string txt2;
    public string vilkor;
    // Use this for initialization

    /*void Start()
    {
        StartCoroutine(kza());
    }
        IEnumerator kza()
        {
            WWW www = new WWW(url);
            yield return www;
            img.texture = www.texture;
            img.SetNativeSize();
        }*/

    public void zmm()
    {
        man = this.GetComponent<zbzob>().main;
        StartCoroutine(Example());
       // StartCoroutine(Example2());
        

    }
    public void zmm2()
    {
        beskrivning.GetComponent<Text>().text = this.GetComponent<textevent>().beskriving;
        date.GetComponent<Text>().text=this.GetComponent<textevent>().date;
        adress.GetComponent<Text>().text = this.GetComponent<textevent>().adress;
        time.GetComponent<Text>().text = this.GetComponent<textevent>().time;
        email.GetComponent<Text>().text = this.GetComponent<textevent>().email;
        ovrigt.GetComponent<Text>().text = this.GetComponent<textevent>().ovrigt;
        namn.GetComponent<Text>().text = this.GetComponent<textevent>().namn;

    }


IEnumerator Example()
    {

        WWW www = new WWW(man);
        yield return www;
        Event.texture = www.texture;
        Event.SetNativeSize();
        //Event.GetComponent<Eventtest2>().url = man;

    }
}
