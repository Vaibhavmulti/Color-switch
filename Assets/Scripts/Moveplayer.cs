using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour {
    public float gravity = 0.5f;
    public float upforce = 1f;
    Rigidbody2D rb;

    public GameObject target;
    Vector3 offset;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        offset = target.transform.position-transform.position;
    }

    // Update is called once per frame
    void Update () {
        //transform.Translate(new Vector3(0f, -gravity * Time.deltaTime, 0));
        if (Input.GetKeyDown(KeyCode.Space) && Score.isdead==false)
        {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upforce));    
        }
        target.transform.position = transform.position + offset;

    }
}
