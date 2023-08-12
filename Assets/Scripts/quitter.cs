using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class quitter : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Debug.Log("Quitter!");
        Application.Quit();
    }
}
