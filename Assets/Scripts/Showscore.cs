using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showscore : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Score.score.ToString();
	}
}
