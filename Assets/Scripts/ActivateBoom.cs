using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

public class ActivateBoom : MonoBehaviour
{
    public VisualEffect magicBurst;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E)) {

            Debug.Log("Magic!");
            PlayMagic();
        }

    }

    void PlayMagic()
    {
        magicBurst.Play();

    }



}

