using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timetorespawn : MonoBehaviour {
    public Vector3 shift = new Vector3(0f,30f,0f);
    GameObject[] storeall;
	// Use this for initialization
	void Start () {
        storeall = GameObject.FindGameObjectsWithTag("RandomColor");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.parent.gameObject.transform.position += shift;
        foreach(GameObject go in storeall)
        {
            go.gameObject.SetActive(true);
        }
    }
}
