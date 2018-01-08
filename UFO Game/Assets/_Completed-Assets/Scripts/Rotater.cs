using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 rotate = new Vector3(0, 0, 30);
        transform.Rotate(rotate * Time.deltaTime);
	}
}
