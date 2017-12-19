using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float rotamount = 45f;
    Vector3 rotate;
    // Use this for initialization
    void Start () {
        rotate = Vector3.zero;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rotate.z += rotamount*Time.deltaTime;
        transform.eulerAngles = rotate;		
	}
}
