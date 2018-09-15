using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject bullet;
	public float playermove;
	public float speed;
	public float bulletspeed;
	public GameObject leftbullet;
	public GameObject rightbullet;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space))
			{
			GameObject bullet01 = (GameObject)Instantiate (bullet);
			bullet01.transform.position = leftbullet.transform.position;

			GameObject bullet02 = (GameObject)Instantiate (bullet);
			bullet02.transform.position = rightbullet.transform.position;

			}
//		playermove = Input.GetAxis ("Horizontal") * Time.deltaTime * 20;

		if (Input.GetKey (KeyCode.LeftArrow)) 
				{
					transform.Translate(Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

//		Vector2 position = transform.position;
//		position = new Vector2 (position.x, position.y + bulletspeed + Time.deltaTime);
//		transform.position = position;
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		if (transform.position.y > max.y) {
			Destroy (gameObject);
		}
//	playermove = Input.GetKey (KeyCode.DownArrow) * Time.deltaTime * 20;
//		transform.Translate (playermove, 0,0);

		transform.position =  new Vector3((Mathf.Clamp(transform.position.x,-3f,3f)),transform.position.y,transform.position.z);


	}
}
