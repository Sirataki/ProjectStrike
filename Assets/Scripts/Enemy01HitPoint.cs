using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01HitPoint : MonoBehaviour
{
	public int hp = 2;
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
		if (collider.gameObject.tag == "PShot")
		{
			hp = hp - power;
			if (hp <= 0)
			{
				Destroy(gameObject);
			}
		}
	}
}
