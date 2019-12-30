using System.Collections;
using UnityEngine;

/*
 * Behaviour to handle keyboard input and also store the player's
 * current health.
 */
public class PlayerController : MonoBehaviour {
    private Rigidbody2D rigidbody2d;
    private int health;
    private bool canJump;
    private bool twoJump;
    private Animator anim;
    public RuntimeAnimatorController walkController;
    public RuntimeAnimatorController jumpController;
    public RuntimeAnimatorController ladderController;

    /*
     * Apply initial health and also store the Rigidbody2D reference for
     * future because GetComponent<T> is relatively expensive.
     */
    private void Start () {
        health = 6;
        twoJump = false;
        rigidbody2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
    }

    /*
     * Remove one health unit from player and if health becomes 0, change
     * scene to the end game scene.
     */
    public void Damage () {
        health -= 2;

        if (health < 1) {
            Application.LoadLevel ("EndGame");
        }
    }
    /*
     * Change scene to the end game scene.
     */
    public void End () {
        Application.LoadLevel ("EndGame");
    }
    /*
     * Let health increase by 1 to recover.
     */
    public void Recover () {
        health += 1;
    }

    /*
     * Accessor for health variable, used by he HUD to display health.
     */
    public int GetHealth () {
        return health;
    }

    /*
     * Poll keyboard for when the up arrow or W is pressed. If the player can do the first jump
     * (is on the ground) then add force to the cached Rigidbody2D component.
     * Then unset the canJump flag and set the twoJump flag, so the player has to wait to land before
     * the first jump can be triggered, and wait to the first jump before the second jump can be triggered.
     */
    private void Update () {
        transform.Translate (new Vector2 (1, 0) * Time.deltaTime);
        if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
            anim.runtimeAnimatorController = jumpController;
            if (twoJump == true) {
                Debug.Log ("twoJump");
                rigidbody2d.AddForce (new Vector2 (50, 200));
                twoJump = false;
            }
            if (canJump == true) {
                Debug.Log ("oneJump");
                rigidbody2d.AddForce (new Vector2 (60, 400));
                canJump = false;
                twoJump = true;
            }

        } else {
            anim.runtimeAnimatorController = walkController;
        }

        if (Input.GetKeyDown (KeyCode.Escape)) {  //Press Esc to the Menu scene.
            Debug.Log ("quit");
            Application.LoadLevel ("Menu");
        }
    }

    /*
     * If the player has collided with the ground, set the canJump flag so that
     * the player can trigger another jump.
     * Set the twoJump flag as false.
     */
    private void OnCollisionEnter2D (Collision2D other) {
        canJump = true;
        twoJump = false;
    }
}