using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : MonoBehaviour
{
	public float speed = 0.0f;
	public int power = 1;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += transform.forward * Time.deltaTime * speed;

		if (!GetComponent<Renderer>().isVisible)
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{

			Destroy(gameObject);
			Debug.Log("EHit");
		}
		if (collider.gameObject.tag == "Map")
		{
			Destroy(gameObject);
		}
	}
}
