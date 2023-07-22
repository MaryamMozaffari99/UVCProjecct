using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGizmos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gizmos;
    public void ActiveGizmo()
    {
        if (Gizmos != null)
        {
            bool isActive = Gizmos.activeSelf;
            Gizmos.SetActive(!isActive);
        }
    }

}
