using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
	public float speed = 0.0f;
	public float life_time = 3.0f;
	// Use this for initialization
	void Start()
	{
		Destroy(gameObject, life_time);
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
		if (collider.gameObject.tag == "Enemy")
		{
			Destroy(gameObject);
			Debug.Log("PHit");
		}
		if (collider.gameObject.tag == "Map")
		{
			Destroy(gameObject);
		}
	}


}
