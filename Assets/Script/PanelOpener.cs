using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BuilderProPanel;
    public void OpenPanel()
    {
        if(BuilderProPanel != null)
        {
            bool isActive = BuilderProPanel.activeSelf;
            BuilderProPanel.SetActive(!isActive);
        }
    }

}
