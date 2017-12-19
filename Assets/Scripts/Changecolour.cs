using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolour : MonoBehaviour {
    //Color[] randomcolor= { Color.red, Color.blue, Color.green,Color.yellow };
    public Color[] randomcolor;
    int randint;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        randint = (int)Random.Range(0f, randomcolor.Length);
        collision.gameObject.GetComponent<SpriteRenderer>().color = randomcolor[randint];
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
