using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
	public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
		InvokeRepeating("FireBullet", 0f, 0.75f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FireBullet(){
 
     

         //Clone of the bullet
        GameObject Clone;
         //spawning the bullet at position
        Clone = (Instantiate(bulletPrefab, transform.position,transform.rotation)) as GameObject;
                  Debug.Log ("Bullet is found");
 
 
         //add force to the spawned objected

        Clone.rigidbody2D.AddForce(Vector2.right*100);
 
        Debug.Log ("Force is added");
     
     }
}
