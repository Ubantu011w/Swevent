using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eventtest : MonoBehaviour
{

    public RawImage parent;
    public RawImage EventRW;
    public string urlhon;

    // Use this for initialization
    void Start()
    {

    }

    public void Event()
    {
        StartCoroutine(kza());
    }
    IEnumerator kza()
    {
        urlhon = parent.GetComponent<result1>().url;
        WWW www = new WWW(urlhon);
        yield return www;
        EventRW.texture = www.texture;
        EventRW.SetNativeSize();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
