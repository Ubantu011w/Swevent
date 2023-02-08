using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class clone : MonoBehaviour
{
    public GameObject fail;
    public Transform parent;
    public GameObject childObject;
    public GameObject eventraw;
    public GameObject loading;
    public Vector2 location1;
    public Vector2 location2;
    public Transform contenta;
    //public Vector2 location; // place you want it 
    public Vector2 localSecale1;
    public Vector2 localSecale2;
    public RectTransform content;
    string url = "http://localhost/sotenas/i.txt";
    string zb;
    string jpg = "1.jpg";
    string txt = ".txt";
    string txt2 = "v.txt";
    string txti = "i.txt";
    string result;
    string result2;
    string result3;
    int bzza;
    string kmale = "http://swevent.net/kommuner/";
    string kommun;
    string slash = "/";
    GameObject online;
    GameObject online2;
    public GameObject newtext;
    string[] testarray = new string[] { "ale", "alingsås", "bengtsförs", "bollebygd", "borås", "dals-Ed", "essunga", "falkoping", "färgelanda", "grastorp", "gullspang", "gatene", "göteborg", "herrljunga", "hjo", "härryda", "karlsborg", "kungälv", "lerum", "lidkoping", "lilla-Edet", "lysekil", "mariestad", "mark", "mellerud", "munkedal", "mölndal", "orust", "partille", "skara", "skövde", "sotenäs", "stenungsund", "strömstad", "svenljunga", "tanum", "tibro", "tidaholm", "tjorn", "tranemo", "trollhättan", "toreboda", "uddevalla", "ulricehamn", "vara", "vargårda", "vänersborg", "åmål", "öckero" };
    GameObject kommunname;
    public GameObject failed;
    public Text foretagname;
    public Text adress;
    public Text beskrivning;
    public Text datumfron;
    public Text datumtill;
    public Text ovrigt;
    public Text mail;
    public Text eventtype;

    private void Awake()
    {
     online = GameObject.Find("online");
        online2 = GameObject.Find("Searchbox");
         content= content.GetComponent(typeof(RectTransform)) as RectTransform;
        kommunname= GameObject.Find("kommunname");
        //bzza = int.Parse(zb);
    }

     public void ghere()
    {
        

    }

    bool Doesit(bool findit)
    {
        string kommunfind;
        kommunfind = null;
        for (int i = 0; i < 49; i++)
        {
            if (testarray[i]== meso(kommunfind))
            {
                findit = false;
            }
            else if(testarray[i] != meso(kommunfind))
            {
                findit = true;
            }
        }
        Debug.Log(findit);
        return findit;
    }

    string meso(string kommun)
    {
        string kommuns= null;
        for (int i = 0; i < 49; i++)
        {
            if (testarray[i] == newtext.GetComponent<InputField>().text.ToLower())
            {

                kommuns = testarray[i];
            }

        }

        Debug.Log("first" + kommuns);
        kommun = kommuns;
        return kommun.ToLower();
   }

    public void kza()
    {
        fail.SetActive(true);
        StartCoroutine(Check());
    }


    public IEnumerator Check()
    {
        string kommunl = null;
        bool find;
        find = true;
        kommunl = meso(kommunl);
        if (kommunl.ToUpper() == "SOTENÄS")
        {
            kommunl = "sotenas";
        }
        else if (kommunl.ToUpper() == "GÖTEBORG")
        {
            kommunl = "goteborg";
        }
        else if (kommunl.ToUpper() == "VÄNNERSBORG")
        {
            kommunl = "vannersborg";
        }
        else if (kommunl.ToUpper() == "ÅMÅL")
        {
            kommunl = "amal";
        }
        else if (kommunl.ToUpper() == "BORÅS")
        {
            kommunl = "boras";
        }
        else if (kommunl.ToUpper() == "ALINGSÅS")
        {
            kommunl = "alingsas";
        }
        else if (kommunl.ToUpper() == "BENGTSFÖRS")
        {
            kommunl = "bengtsfors";
        }
        else if (kommunl.ToUpper() == "HÄRRYDA")
        {
            kommunl = "harryda";
        }
        else if (kommunl.ToUpper() == "TROLLHÄTTAN")
        {
            kommunl = "trollhattan";
        }
        else if (kommunl.ToUpper() == "SKÖVDE")
        {
            kommunl = "skovde";
        }
        else if (kommunl.ToUpper() == "FÄRGELANDA")
        {
            kommunl = "fargelanda";
        }
        else if (kommunl.ToUpper() == "KUNGÄLV")
        {
            kommunl = "kungalv";
        }
        else if (kommunl.ToUpper() == "ÖCKERO")
        {
            kommunl = "ockero";
        }

        Debug.Log(kommunl);
        find=Doesit(find);
        Debug.Log("b2a5erw7de"+Doesit(find)+" "+find);

        if (find==true)
        {
            fail.SetActive(false);
            //failed.SetActive(false);
            loading.SetActive(true); 
        kommunname.GetComponent<Text>().text = kommunl.ToUpper();
            kommunl = kommunl.ToUpper();
        url = kmale + kommunl + slash + txti;
        WWW w = new WWW(url);
        yield return w;
        online.GetComponent<Text>().text = w.text;
            int rakam = int.Parse(online.GetComponent<Text>().text);
        int rakamminus = rakam - 1;
        string rakamminustext = rakamminus.ToString();
        online.GetComponent<Text>().text = rakamminustext;
        content.sizeDelta = new Vector2(463.5f, 300 * rakam-1);
        for (int i = 1; i <= rakam; i++)
        {

                location2 = new Vector2(0, 1500 - 450 * i);
                //Instantiate(childObject, location2, Quaternion.identity);
                GameObject kzamk = Instantiate(childObject, location2, Quaternion.identity) as GameObject;
                kzamk.transform.SetParent(parent.transform, false);
                jpg = ".jpg";
                string myString = i.ToString();
                string filename = Application.persistentDataPath + "/file" + myString + ".txt";
                result = kmale + kommunl + slash + myString + jpg;
                result2 = kmale + kommunl + slash + myString + txt;
                Debug.Log(result2);
                WWW x = new WWW(result2);
                yield return x;
                System.IO.File.WriteAllText(filename, x.text);
                string[] lines = System.IO.File.ReadAllLines(filename);
                kzamk.GetComponent<eventype>().type = lines[7];
                foretagname.GetComponent<Text>().text = lines[0];
                adress.GetComponent<Text>().text = lines[1];
                datumfron.GetComponent<Text>().text = lines[3];
                beskrivning.GetComponent<Text>().text = lines[2];
                datumtill.GetComponent<Text>().text = lines[4];

            kzamk.GetComponent<textevent>().date = lines[3];
            kzamk.GetComponent<textevent>().adress = lines[1];
            kzamk.GetComponent<textevent>().time = lines[4];
            kzamk.GetComponent<textevent>().email = lines[6];
            kzamk.GetComponent<textevent>().ovrigt = lines[5];
                WWW xi = new WWW(result);
                yield return xi;
                Instantiate(kzamk, location2, Quaternion.identity);
                if (kzamk.GetComponent<Text>().text=="")
                {
                Destroy(kzamk);
                }
                //kzamk.GetComponent<RawImage>().texture = xi.texture;
                eventraw.GetComponent<RawImage>().texture = xi.texture;
                kzamk.GetComponent<zbzob>().main = result;
                // kzamk.transform.localScale = localSecale2;
        }
        Debug.Log("hihi");
        if (contenta.transform.childCount != rakam-1)
        {
            Debug.Log("mar7aba");
            Destroy(contenta.GetComponent<Transform>().GetChild(0).gameObject);
        }
        loading.SetActive(false);
        }

        else if (find==false)
        {
            failed.SetActive(true);
        }
    }

}
