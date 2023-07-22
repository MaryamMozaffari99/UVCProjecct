using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TramsformUI;
    public void OpenTransform()
    {
        if (TramsformUI != null)
        {
            bool isActive = TramsformUI.activeSelf;
            TramsformUI.SetActive(!isActive);
        }
    }

}
