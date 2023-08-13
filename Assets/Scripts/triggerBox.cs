using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBox : MonoBehaviour
{
    public GameObject player;
    public GameObject SolvedLight;
    public GameObject ProblemLight;
    [SerializeField] GameObject Puzzle;
    public BoxCollider Collider;

    bool BoxCollider;

    LookDetect _looked;
    
    //PuzzleCheck1 _pCheck1;
    //PuzzleCheck2 _pCheck2;

    void Awake()
    {
        _looked = Puzzle.GetComponent<LookDetect>();
        Debug.Log("got component");
    }

    void Update()
    {
        _looked.OnMouseOver();

    }

    
    /*
    private void onTriggerEnter(Collider other)
    {
        _pCheck1 = true;
    } else {
        _pCheck1 = false;
    }
    */




}