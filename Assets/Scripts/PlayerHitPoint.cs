using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitPoint : MonoBehaviour
{
	public int hp = 3;
	public int power = 1;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "EShot")
		{
			hp = hp - power;
			if (hp <= 0)
			{
				Destroy(gameObject);
				Application.LoadLevel("Title");
			}
		}
		if (collider.gameObject.tag == "UnderGround")
		{
			Destroy(gameObject);
			Application.LoadLevel("Title");
		}
	}
}
