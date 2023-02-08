using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopanimation : MonoBehaviour {
    GameObject scrollingm;
    GameObject button;
    private Animator anim;
    // Use this for initialization
    void Awake () {
        scrollingm = GameObject.Find("scrollingm");
        button = GameObject.Find("Stopanimation");
        anim = GetComponent<Animator>();
    }

    public void stop()
    {
        scrollingm.gameObject.GetComponent<Animator>().enabled = false;
        StartCoroutine(Wait());

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10F);
        scrollingm.GetComponent<Animator>().Rebind();
        scrollingm.gameObject.GetComponent<Animator>().enabled = true;
        button.SetActive(true);
    }
}
