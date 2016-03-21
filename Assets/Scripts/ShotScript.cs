using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

  //Public Variables
  public int damage = 1;
  public bool isEnemyShot = false;


	// Use this for initialization
	void Start () {
    Destroy(gameObject, 5); // 5 Seconds, gets destroyed
	
	}		
}
