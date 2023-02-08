using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Newshit : MonoBehaviour {

	
	public RawImage img;
    public string url = "https://i.imgur.com/arlOa7a.jpg";
    public string url2 = "https://i.imgur.com/RAqrRaL.jpg";
	
	// Use this for initialization
	void Start () {
		
	}
	
	public void kzachanged()
    {
        StartCoroutine(Example());



    }

    IEnumerator Example()
    {

        if (GameObject.Find("Searchbox").GetComponent<InputField>().text == "Lysekil")
        //while (true)
        { // This creates a never-ending loop
          //    yield return new WaitForSeconds(2);
            WWW www = new WWW(url);
            yield return www;
            img.texture = www.texture;
            img.SetNativeSize();

        }

        else if (GameObject.Find("Searchbox").GetComponent<InputField>().text == "Sotenäs")
        {

            WWW www = new WWW(url2);
            yield return www;
            img.texture = www.texture;
            img.SetNativeSize();
        }

        else
        {
		
        	
        }
        
    }
}