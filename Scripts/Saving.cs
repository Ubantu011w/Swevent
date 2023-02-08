using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Saving : MonoBehaviour {
    public RawImage image;
    public Texture inga;
    string url;

     void Start()
    { 
            url = PlayerPrefs.GetString("url", url);
        //StartCoroutine(cloneimg());
    }

    public void clone()
    {
        image.GetComponent<RawImage>().texture = this.GetComponent<RawImage>().texture;
        PlayerPrefs.SetString("url", url);
    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
        image.GetComponent<RawImage>().texture = inga;
        //StartCoroutine(cloneimg());
    }

    // Update is called once per frame
    public IEnumerator cloneimg()
        {
            WWW www = new WWW(url);
            yield return www;
            image.texture = www.texture;
            image.SetNativeSize();
        }

    }
