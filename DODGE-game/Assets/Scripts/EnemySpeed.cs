using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{
    public GameObject anim;
    public GameObject textOBJ;
    Animator theAnimator;

    // Use this for initialization
    void Start()
    {
         theAnimator = anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        theAnimator.speed = textOBJ.GetComponent<PointSys>().points / Random.Range(100,701);
    }
}
