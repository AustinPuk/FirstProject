using UnityEngine;
using System.Collections;

///
/// Player Controller and Behavior
///

public class PlayerScript : MonoBehaviour {
  
  //1 - The speed of the ship
  public Vector2 speed = new Vector2(50, 50);
  
  //2 - Store the movement
  private Vector2 movement;      

	
	// Update is called once per frame
	void Update () {
      //3 - Retrieve Axis information
      float inputX = Input.GetAxis("Horizontal");
      float inputY = Input.GetAxis("Vertical");
      
      //4 - Movement per direction
      movement = new Vector2(
        speed.x * inputX, 
        speed.y * inputY);      
	}
  
  void FixedUpdate(){
    //5 - Move the game object
    GetComponent<Rigidbody2D>().velocity = movement;
  }
  
  
  
}

  
