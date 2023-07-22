using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gizmos;
    public void OpenPanel()
    {
        if (Gizmos != null)
        {
            bool isActive = Gizmos.activeSelf;
            Gizmos.SetActive(!isActive);
        }
    }

}
