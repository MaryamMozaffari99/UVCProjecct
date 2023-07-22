using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainmenu;
    public void OpenMainmenu()
    {
        if (mainmenu != null)
        {
            bool isActive = mainmenu.activeSelf;
            mainmenu.SetActive(!isActive);
        }
    }

}
