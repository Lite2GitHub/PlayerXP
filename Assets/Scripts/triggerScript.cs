using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    Animator _swordAnim;
    GameObject sword_altar;

    

    private void OnTriggerEnter(Collider other)
    {
        _swordAnim.SetTrigger("beginRise");
        sword_altar.GetComponent<Outline>().enabled = true;

    }
     void Start()
    {
        _swordAnim = this.transform.parent.GetComponent<Animator>();
    }

     void Update()
    {

    }
}