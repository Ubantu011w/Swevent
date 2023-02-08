using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trending : MonoBehaviour
{
    string result = "http://swevent.net/TRENDING/1";
    public Text adress;
    public Text datumfron;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Check());
    }

    // Update is called once per frame
    public IEnumerator Check()
    {
        WWW xi = new WWW(result+".jpg");
        yield return xi;
        this.GetComponent<RawImage>().texture = xi.texture;
        string filename = Application.persistentDataPath + "/file" + "trending1" + ".txt";
        WWW x = new WWW(result+".txt");
        yield return x;
        System.IO.File.WriteAllText(filename, x.text);
        string[] lines = System.IO.File.ReadAllLines(filename);
        this.GetComponent<eventype>().type = lines[7];
        adress.GetComponent<Text>().text = lines[1];
        datumfron.GetComponent<Text>().text = lines[3];
        this.GetComponent<textevent>().namn = lines[0];
        this.GetComponent<textevent>().adress = lines[1];
        this.GetComponent<textevent>().beskriving = lines[2];
        this.GetComponent<textevent>().date = lines[3];
        this.GetComponent<textevent>().time = lines[4];
        this.GetComponent<textevent>().ovrigt = lines[5];
        this.GetComponent<textevent>().email = lines[6];
    }

}
