using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	float Speed = 0.4f;
	float SecondsUntilDestroy = 10;
	float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.gameObject.transform.position += Speed * this.gameObject.transform.forward;
		if(Time.time - startTime >= SecondsUntilDestroy){
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision collision){
		Destroy(this.gameObject);
		//remove 1 life from bird
	}
}
