using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour {
    public Rigidbody2D rigidbody2d;
    public void Start () {
        rigidbody2d = GetComponent<Rigidbody2D> ();
    }
    public void Update () {
        if (Input.GetKeyDown (KeyCode.UpArrow)) {
            rigidbody2d.AddForce (new Vector2 (0, 300));
        }
        if (Input.GetKeyDown (KeyCode.Escape)) {
            Debug.Log ("quit");
            Application.LoadLevel ("Menu");
        }
    }
    public void OnTriggerEnter2D (Collider2D other) {
        Debug.Log ($"{other.tag}");
        if (other.tag == "portal") {
            Application.LoadLevel ("Win");
        } else {
            Application.LoadLevel ("EndGame");
        }
    }
}