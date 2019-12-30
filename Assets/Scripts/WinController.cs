using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour {
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            Application.LoadLevel ("Menu");
        }
    }
}