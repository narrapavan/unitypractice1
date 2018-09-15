using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {
	public GameObject bullet;
	public GameObject leftbullet;
	public GameObject rightbullet;
	public float bulletspeed;
	// Use this for initialization
	void Start () {
		bulletspeed = 8f;
	}
	
	// Update is called once per frame
	void Update () {
        
		Vector2 position = transform.position;
		position = new Vector2 (position.x, position.y + bulletspeed + Time.deltaTime);
		transform.position = position;
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		if (transform.position.y > max.y) {
			Destroy (gameObject);
		}
	}
}

