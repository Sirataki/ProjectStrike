using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Direction of Caracter's face
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.rotation = Quaternion.Euler(0, 90, 0);
		}
		else if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.rotation = Quaternion.Euler(0, -90, 0);
		}
	}
}
