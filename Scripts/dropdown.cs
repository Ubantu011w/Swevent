//Create a new Dropdown GameObject by going to the Hierarchy and clicking Create>UI>Dropdown. Attach this script to the Dropdown GameObject.
//Set your own Text in the Inspector window
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    Dropdown m_Dropdown;
    public GameObject m_Text;
    public GameObject searchbox;
    List<string> m_A = new List<string> { "Ale", "Alingsås" };
    List<string> m_B = new List<string> { "Bengtsförs", "Bollebygd", "Borås" };
    List<string> m_D = new List<string> { "Dals-Ed" };
    List<string> m_E = new List<string> { "Essunga",};
    List<string> m_F = new List<string> { "Falkoping", "Färgelanda" };
    List<string> m_G = new List<string> { "Grastorp", "Gullspang", "Gatene", "Göteborg" };
    List<string> m_H = new List<string> { "Herrljunga", "Hjo", "Härryda" };
    List<string> m_K = new List<string> { "Karlsbörg", "Kungälv" };
    List<string> m_L = new List<string> { "Lerum", "Lidkoping", "Lilla-Edet", "Lysekil" };
    List<string> m_M = new List<string> { "Mariestad", "Mark", "Mellerud", "Munkedal", "Mölndal" };
    List<string> m_O = new List<string> { "Orust"};
    List<string> m_P = new List<string> { "Partille"};
    List<string> m_S = new List<string> { "Skara", "Skövde", "Sotenäs", "Stenungsund", "Strömstad", "Svenljunga" };
    List<string> m_T = new List<string> { "Tanum", "Tibro", "Tidaholm", "Tjorn","Tranemo", "Trollhättan", "Toreboda" };
    List<string> m_U = new List<string> { "Uddevalla", "Ulricehamn" };
    List<string> m_V = new List<string> { "Vara", "Vargårda", "Vänersborg" };
    List<string> m_Å = new List<string> { "Åmål" };
    List<string> m_Ö = new List<string> { "Öckero" };
    List<string> m_in = new List<string> { "Inga-kommuner", "Inga-kommuner" };



    string[] testarray = new string[] { "", "ale", "alingsås", "bengtsförs", "bollebygd", "borås", "dals-Ed", "essunga", "falkoping", "färgelanda", "grastorp", "gullspang", "gatene", "göteborg", "herrljunga", "hjo", "härryda", "karlsborg", "kungälv", "lerum", "lidkoping", "lilla-Edet", "lysekil", "mariestad", "mark", "mellerud", "munkedal", "mölndal", "orust", "partille", "skara", "skövde", "sotenäs", "stenungsund", "strömstad", "svenljunga", "tanum", "tibro", "tidaholm", "tjorn", "tranemo", "trollhättan", "toreboda", "uddevalla", "ulricehamn", "vara", "vargårda", "vänersborg", "åmål", "öckero" };

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });

        //Initialise the Text to say the first value of the Dropdown
        m_Text.GetComponent<InputField>().text = "";

    }

    //Ouput the new value of the Dropdown into Text
    public void DropdownValueChanged(Dropdown change)
    {
        char[] myChars = m_Text.GetComponent<InputField>().text.ToCharArray();

        if (myChars[0] == 'A' || myChars[0] == 'a')
        { 
            m_Text.GetComponent<InputField>().text = m_A[change.value];
        }
        if (myChars[0] == 'B' || myChars[0] == 'b')
        {
            m_Text.GetComponent<InputField>().text = m_B[change.value];
        }
        if (myChars[0] == 'D' || myChars[0] == 'd')
        {
            m_Text.GetComponent<InputField>().text = m_D[change.value];
        }
        if (myChars[0] == 'E' || myChars[0] == 'e')
        {
            m_Text.GetComponent<InputField>().text = m_E[change.value];
        }
        if (myChars[0] == 'F' || myChars[0] == 'f')
        {
            m_Text.GetComponent<InputField>().text = m_F[change.value];
        }
        if (myChars[0] == 'G' || myChars[0] == 'g')
        {
            m_Text.GetComponent<InputField>().text = m_G[change.value];
        }
        if (myChars[0] == 'H' || myChars[0] == 'h')
        {
            m_Text.GetComponent<InputField>().text = m_H[change.value];
        }
        if (myChars[0] == 'K' || myChars[0] == 'k')
        {
            m_Text.GetComponent<InputField>().text = m_K[change.value];
        }
        if (myChars[0] == 'L' || myChars[0] == 'l')
        {
            m_Text.GetComponent<InputField>().text = m_L[change.value];
        }
        if (myChars[0] == 'M' || myChars[0] == 'm')
        {
            m_Text.GetComponent<InputField>().text = m_M[change.value];
        }
        if (myChars[0] == 'O' || myChars[0] == 'o')
        {
            m_Text.GetComponent<InputField>().text = m_O[change.value];
        }
        if (myChars[0] == 'P' || myChars[0] == 'p')
        {
            m_Text.GetComponent<InputField>().text = m_P[change.value];
        }
        if (myChars[0] == 'S' || myChars[0] == 's')
        {
            m_Text.GetComponent<InputField>().text = m_S[change.value];
        }
        if (myChars[0] == 'T' || myChars[0] == 't')
        {
            m_Text.GetComponent<InputField>().text = m_T[change.value];
        }
        if (myChars[0] == 'U' || myChars[0] == 'u')
        {
            m_Text.GetComponent<InputField>().text = m_U[change.value];
        }
        if (myChars[0] == 'V' || myChars[0] == 'v')
        {
            m_Text.GetComponent<InputField>().text = m_V[change.value];
        }
        if (myChars[0] == 'Å' || myChars[0] == 'å')
        {
            m_Text.GetComponent<InputField>().text = m_Å[change.value];
        }
        if (myChars[0] == 'Ö' || myChars[0] == 'ö')
        {
            m_Text.GetComponent<InputField>().text = m_Ö[change.value];
        }
        if (myChars[0] == 'C' || myChars[0] == 'c')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'I' || myChars[0] == 'i')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'J' || myChars[0] == 'j')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'N' || myChars[0] == 'n')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'Q' || myChars[0] == 'q')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'R' || myChars[0] == 'r')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'W' || myChars[0] == 'w')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'X' || myChars[0] == 'x')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'Y' || myChars[0] == 'y')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'Z' || myChars[0] == 'z')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
        if (myChars[0] == 'Ä' || myChars[0] == 'ä')
        {
            m_Text.GetComponent<InputField>().text = m_in[change.value];
        }
    }
    void Show(Dropdown show)
    {
        m_Text.GetComponent<InputField>().text = "2ere";
    }
    public void changedshit()
    {
        char[] myChars = m_Text.GetComponent<InputField>().text.ToCharArray();
        if (myChars[0] == 'A'|| myChars[0] == 'a')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_A);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'B' || myChars[0] == 'b')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_B);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'D' || myChars[0] == 'd')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_D);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'E' || myChars[0] == 'e')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_E);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'F' || myChars[0] == 'f')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_F);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'G' || myChars[0] == 'g')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_G);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'H' || myChars[0] == 'h')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_H);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'K' || myChars[0] == 'k')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_K);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'L' || myChars[0] == 'l')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_L);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'M' || myChars[0] == 'm')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_M);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'O' || myChars[0] == 'o')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_O);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'P' || myChars[0] == 'p')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_P);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'S' || myChars[0] == 's')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_S);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'T' || myChars[0] == 't')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_T);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'U' || myChars[0] == 'u')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_U);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'V' || myChars[0] == 'v')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_V);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'Å' || myChars[0] == 'å')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_Å);
            m_Dropdown.RefreshShownValue();

        }
        if (myChars[0] == 'Ö' || myChars[0] == 'ö')
        {
            m_Dropdown.ClearOptions();
            m_Dropdown.AddOptions(m_Ö);
            m_Dropdown.RefreshShownValue();

        }

    }
}
