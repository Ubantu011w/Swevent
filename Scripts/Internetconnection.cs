using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Internetconnection : MonoBehaviour {
  
    public GameObject offlinepanel;

    // Use this for initialization

    private void Awake()
    {
      
    }
    void Start () {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
  
            offlinepanel.SetActive(true);
        }
        else
        {
            offlinepanel.SetActive(false);

        }

      
	}
	
}
