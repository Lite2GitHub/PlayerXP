using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    Animator _swordAnim;

    private void OnTriggerEnter(Collider other)
    {
        _swordAnim.SetTrigger("beginRise");
    }
     void Start()
    {
        _swordAnim = this.transform.parent.GetComponent<Animator>();
    }

     void Update()
    {

    }
}