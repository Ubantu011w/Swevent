using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockerremove : MonoBehaviour {

    // Use this for initialization
     public void remove()
    { 
    GameObject remove = GameObject.Find("Blocker");
        Destroy(remove);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
