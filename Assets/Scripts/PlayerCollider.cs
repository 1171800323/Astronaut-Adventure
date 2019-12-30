using UnityEngine;

/*
 * Provide the obstacles with a way of damaging the player.
 */
public class PlayerCollider : MonoBehaviour {
  /*
   * A trigger callback to detect when the player's collider has
   * entered the obstacle's. Then simply obtain the PlayerController
   * reference can apply damage. Then remove the obstacle for feedback.
   */
  private void OnTriggerEnter2D (Collider2D other) {
    // Obtain a reference to the Player's PlayerController
    PlayerController playerController = other.gameObject.GetComponent<PlayerController> ();
    if (gameObject.tag.Equals ("spike")) {
      playerController.End ();      // Register spike with player
    } else if (gameObject.tag.Equals ("damage")) {
      playerController.Damage ();   // Register damage with player
    } else if (gameObject.tag.Equals ("Food")) {
      playerController.Recover ();  // Register Food with player
    }
    // Make this object disappear
    GameObject.Destroy (gameObject);
  }
  private void OnCollisionEnter2D (Collision2D other) {
    PlayerController playerController = other.gameObject.GetComponent<PlayerController> ();
    if (gameObject.tag.Equals ("damageTwo")) {
      playerController.Damage ();
    }
  }
}