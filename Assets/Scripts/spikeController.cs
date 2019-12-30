using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeController : MonoBehaviour {
  private void OnTriggerEnter2D (Collider2D other) {
    // Obtain a reference to the Player's PlayerController
    PlayerController playerController =
      other.gameObject.GetComponent<PlayerController> ();

    playerController.End ();
  }
}