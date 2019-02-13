using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    AudioSource audioData;

    public float speed = 1;

    public Text countText;

    public Text winText;

    private int count;

    private bool isGrounded = true;

    public float jumpPower = 3f;

    void Start () {

      count = 0;
      SetCountText ();
      winText.text = "";
    }
    // If they're colliding with something, mark them as grounded
    private void OnCollisionStay(Collision collision) {
    	// Bumping into non-ground stuff doesn't count
    	if (!collision.gameObject.CompareTag("floor")) {
    		return;
    	}

    	isGrounded = true;
    }
	// move the player
	private void FixedUpdate () {

    if (Input.GetButton("Jump") && isGrounded) {
		GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
		isGrounded = false;
}

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0, moveVertical);

        GetComponent<Rigidbody>().AddForce(move*speed);

	}
  void OnTriggerEnter(Collider other){

      if (other.gameObject.CompareTag("Pick Up")){
        other.gameObject.SetActive (false);
        count = count + 1;
        SetCountText ();
        }
  }
  void SetCountText() {
    countText.text = "Count: " + count.ToString ();
    if (count >= 12){
      winText.text = "You win!";
    }
  }
}
//Destroy(other.gameObject);
