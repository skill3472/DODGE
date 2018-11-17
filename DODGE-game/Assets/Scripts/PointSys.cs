using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSys : MonoBehaviour {


    public float points;
    public Text counter;


    // Use this for initialization
    void Start ()
    {
        counter = GetComponent<Text>();
        points = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
            
            points = points + 1;
            counter.text = points.ToString();

	}
}
