using UnityEngine;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour {
  /*
   * When the start button is pressed, load the Game scene.
   */
  public void OnStartClicked () {
    Application.LoadLevel ("Game");
  }

  /*
   * When the back button is clicked, load the Menu scene.
   */
  public void OnBackClicked () {
    Application.LoadLevel ("Menu");
  }
  /*
   * When the Quit Button is clicked, exit the game.
   */
  public void QuitGame () {
    Application.Quit ();
  }
  /*
   * When the Second Button is clicked, load the SecondLevel scene.
   */
  public void SecondLevel () {
    Application.LoadLevel ("SecondLevel");
  }
}