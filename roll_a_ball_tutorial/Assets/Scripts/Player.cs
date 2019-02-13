using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float speed = 1;

    public Text countText;

    public Text winText;

    private int count;

    void Start () {
      count = 0;
      SetCountText ();
      winText.text = "";
    }

	// move the player
	private void FixedUpdate () {

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
