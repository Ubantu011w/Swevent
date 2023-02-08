using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear : MonoBehaviour {

    public Text placeholder;
    public GameObject arrow;

    public void childrenclear()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
    }
     void Update()
    {
       if(placeholder.GetComponent<Text>().enabled==true)
        {
            arrow.SetActive(false);
        }
        else if(placeholder.GetComponent<Text>().enabled == false)
        {
            arrow.SetActive(true);
        }
    }
}
