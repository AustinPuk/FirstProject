using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {
  
  //Public Variables
  public Transform shotPrefab;
  public float shootingRate = 0.25f;
  
  //Private Variables
  private float shootCooldown;

	// Use this for initialization
	void Start () {
    shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
    if(shootCooldown > 0) {
      shootCooldown -= Time.deltaTime;
    }
	}
  
  
  //Shooting Method
  public void Attack(bool isEnemy) {
    if (CanAttack) {
      shootCooldown = shootingRate;
      
      //Create a new shot
      var shotTransform = Instantiate(shotPrefab) as Transform;
      
      //Assign Position
      shotTransform.position = transform.position;
      
      //The isEnemy property
      ShotScript shot = 
        shotTransform.gameObject.GetComponent<ShotScript>();
        
      if (shot != null) {
        shot.isEnemyShot = isEnemy;
      }
        
      //Make the weapon shot always towards it
      MoveScript move = 
        shotTransform.gameObject.GetComponent<MoveScript>();
      if (move != null)
      {
        move.direction = this.transform.right; //Towards in 2D space
      }    
    }
  }
  
  public bool CanAttack
  {
    get
    {
     return shootCooldown <= 0f; 
    }
  }
  
}
