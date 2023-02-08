
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchchar : MonoBehaviour
{
    //Create a List of new Dropdown options
    List<string> m_DropOptions = new List<string> { "Option 1", "Option 2" };
    //This is the Dropdown
    Dropdown m_Dropdown;

    void Start()
    {
        //Fetch the Dropdown GameObject the script is attached to
        m_Dropdown = GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        //Add the options created in the List above
        m_Dropdown.AddOptions(m_DropOptions);
    }
}