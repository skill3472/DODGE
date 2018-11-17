using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour {
    public Rigidbody rb;
    public GameObject score;
    // Use this for initialization
    void Start () {
		
	}

    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Obstacle")
        {
            Destroy(score);
            rb.AddForce(0, 1000, -500);
            Destroy(gameObject, .5f);
        }
    }
	// Update is called once per frame
	void Update () {


    }
}
