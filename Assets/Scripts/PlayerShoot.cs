using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject shot;
	public GameObject muzzle;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(shot, muzzle.transform.position, transform.rotation);
		}
	}
}
