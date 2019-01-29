using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	GameObject player;
	GameObject mainCamera;

	void Start()
	{
		player = GameObject.Find("Player");
		mainCamera = GameObject.Find("Main Camera");
	}

	void Update()
	{
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 3, -15);
	}
}
