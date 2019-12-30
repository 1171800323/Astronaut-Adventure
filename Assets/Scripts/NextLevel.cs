using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {
    /*
     * After the first pass, enter the second level, load the SecondLevel scene.
     */
    public void OnTriggerEnter2D (Collider2D collider2D) {
        Application.LoadLevel ("SecondLevel");
    }
}