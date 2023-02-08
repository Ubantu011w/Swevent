using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eventype : MonoBehaviour
{
	public GameObject eventtex;
	public Texture place;
	public Texture rest;
	public Texture idrott;
    public Texture rea;
    public Texture uppvisning;
    public string type;

    void Update()
    
{
	if (type=="1")
	{
	eventtex.GetComponent<RawImage>().texture=place;
	}
	else if (type=="2")
	{
	eventtex.GetComponent<RawImage>().texture=rest;
	}
	else if (type=="3")
	{
	eventtex.GetComponent<RawImage>().texture=idrott;
	}
	else if (type=="4")
	{
	eventtex.GetComponent<RawImage>().texture=rea;
	}
    else if (type == "5")
    {
    eventtex.GetComponent<RawImage>().texture =uppvisning;
    }

    }
    
	}
