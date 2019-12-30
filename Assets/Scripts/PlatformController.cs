using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Control Platform to move up and down repeatedly.
 */
public class PlatformController : MonoBehaviour {
    private float radian = 0;
    private float perRadian = 0.03f; // radian of each change
    private float radius = 0.8f;
    Vector3 oldPos; // Coordinates at the beginning
    void Start () {
        oldPos = transform.position; // Save the original location to oldPos
    }
    void Update () {
        // Radius plus 0.03 each time
        radian += perRadian;
        // dy defines the variable for the y-axis, you can also use sin, as long as you find a suitable value
        float dy = Mathf.Cos (radian) * radius;
        if (gameObject.tag.Equals ("PlatUp")) {
            transform.position = oldPos + new Vector3 (0, dy, 0);
        } else if (gameObject.tag.Equals ("PlatDown")) {
            transform.position = oldPos - new Vector3 (0, dy, 0);
        }
    }
}