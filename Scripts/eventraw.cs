using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eventraw : MonoBehaviour {

    public RawImage Event;
    public void zmm()
    {
        Event.texture = this.GetComponent<RawImage>().texture;
        // StartCoroutine(Example2());


    }

    // Update is called once per frame
    void Update () {
		
	}
}
