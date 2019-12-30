using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Attached to the section so that everything will scroll sideways.
 * The player does not move in this game, the environment does.
 */
public class SecondSectionScroller : MonoBehaviour {
    /*
     * Use the Transform component attached to the section game object and
     * translate it based on delta time.
     */
    void Update () {
        transform.Translate (new Vector2 (-1, 0) * Time.deltaTime);
    }
}