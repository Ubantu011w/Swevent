using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuback : MonoBehaviour {

    GameObject menu;
    GameObject littleone;
    public GameObject saved;

    private void Awake()
    {
        menu = GameObject.Find("Menuback");
    }
    public void waituntil()
    {

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.35F);
        menu.SetActive(false);
    }
    public void waituntil2()
    {

        StartCoroutine(Wait2());
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2.5F);
        saved.SetActive(false);
    }

}
