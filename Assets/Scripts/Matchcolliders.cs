using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matchcolliders : MonoBehaviour {
    SpriteRenderer Sr;
	// Use this for initialization
	void Start () {
        Sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!(collision.tag=="Wall"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().color != Sr.color)
            {
                Score.isdead = true;
                Debug.Log(collision.name);
            }
        }
        
    }
}
