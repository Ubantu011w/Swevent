using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zbzob : MonoBehaviour
{
    private string kmale = "http://localhost/sotenas/";
    public string url = "1.jpg";
    public string url2 = "https://i.imgur.com/A9HFWBA.jpg";
    public string main;
    public string main2;
    public string main3;
    public string txt="1.txt";
    public RawImage img;
    public GameObject textonbild;

    public Text foretagname;
    public Text adress;
    public Text beskrivning;
    public Text datumfron;
    public Text datumtill;
    public Text ovrigt;
    public Text mail;
    public Text eventtype;

    void Awake()
    {
        img = this.gameObject.GetComponent<RawImage>();
        main = kmale + url;
        main2 = kmale + txt;
    }

    // Use this for initialization
    /*IEnumerator Start()
    {
        WWW www = new WWW(main);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
        WWW w = new WWW(txt);
        yield return w;
        textonbild.GetComponent<Text>().text = w.text;

    }*/

    // Update is called once per frame
    void Update()
    {

    }
}
