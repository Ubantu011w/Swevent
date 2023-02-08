using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img1 : MonoBehaviour
{


    public RawImage img;
    public string url = "https://i.imgur.com/qgsZ5rG.jpg";
    public string url2 = "https://i.imgur.com/A9HFWBA.jpg";




    void Start()
    {
        StartCoroutine(Example());



    }

    IEnumerator Example()
    {

       
        //while (true)
        { // This creates a never-ending loop
          //    yield return new WaitForSeconds(2);
            WWW www = new WWW(url);
            yield return www;
            img.texture = www.texture;
            //img.SetNativeSize();

        }







    }

}