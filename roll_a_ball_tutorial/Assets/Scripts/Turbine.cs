using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbine : MonoBehaviour {

    public float turbinespeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.down * turbinespeed * Time.deltaTime);
	}
}
