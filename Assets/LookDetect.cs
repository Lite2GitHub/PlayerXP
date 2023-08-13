using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDetect : MonoBehaviour
{
    
    public bool _looked = false;

    public void OnMouseOver()
    {
        _looked = true;
        Debug.Log("Seen by Detection");
    }
}

