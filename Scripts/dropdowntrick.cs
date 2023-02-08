using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropdowntrick : MonoBehaviour {

    public GameObject m_Dropdown;
    private void Awake()
    {
        
    }

    // Update is called once per frame
    public void wait () {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        m_Dropdown.SetActive(false);
    }
}
