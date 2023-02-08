using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Doubleclick : MonoBehaviour, IPointerClickHandler
{
    int tap;
	public GameObject kza;
	
	void Start()
	{
		
		kza=GameObject.Find("sparade");
	}
	
    public void OnPointerClick(PointerEventData eventData)
    {
        tap = eventData.clickCount;

        if (tap == 2)
        {
            Debug.Log("Sparat i favoriter.", gameObject);
            kza.GetComponent<Text>().text = "Du har sparat 1 event";
        }

    }
}
