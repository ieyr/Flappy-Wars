using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float fireRate = 5;
	public LayerMask notToHit;

	float timeToFire = 0;
	Transform firePoint;
	// Use this for initialization
	void Awake () {	
		InvokeRepeating("shootUpdate", 0f, 1f);
		firePoint = transform.FindChild("FirePoint");
		if(firePoint==null){
			Debug.LogError("No firepoint WHAT?!");
		}
	}
	void shootUpdate(){
		Shoot();
	}
	
	// Update is called once per frame
	void Update () {
	}
	void Shoot(){
		Debug.Log("Test");
		RaycastHit2D hit = Physics2D.Raycast (new Vector2(transform.position.x+1, transform.position.y), new Vector2(transform.position.x+2, transform.position.y));

		Debug.DrawLine(new Vector2(transform.position.x+1, transform.position.y), new Vector2(transform.position.x+2, transform.position.y));
	}
}
