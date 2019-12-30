using UnityEngine;

/*
 * On screen HUD to display current health.
 */
public class PlayerHud : MonoBehaviour {
  private PlayerController playerController;
  private Texture2D halfHeart;
  private Texture2D heart;

  /*
   * Load and store the heart images and cache the PlayerController
   * component for later.
   */
  private void Start () {
    playerController = GetComponent<PlayerController> ();
    heart = Resources.Load<Texture2D> ("heart");
    halfHeart = Resources.Load<Texture2D> ("halfHeart");
  }

  /*
   * Using the current health from the PlayerController, display the
   * correct number of hearts and half hearts.
   */
  private void OnGUI () {
    int score = playerController.GetHealth ();
    if (score % 2 == 0) {
      for (int i = 0; i < playerController.GetHealth (); i = i + 2) {
        GUI.DrawTexture (new Rect (10 + 15 * i, 10, 30, 30), heart);
      }
    } else {
      for (int i = 1; i < playerController.GetHealth (); i = i + 2) {
        GUI.DrawTexture (new Rect (10 + 15 * i, 10, 30, 30), heart);
      }
      GUI.DrawTexture (new Rect (10 + 15 * score, 10, 30, 30), halfHeart);
    }
  }
}