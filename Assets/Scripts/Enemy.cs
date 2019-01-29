using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	GameObject target;
	public GameObject shot;

	float shotInterval = 0;
	public float shotIntervalMax = 1.0f;

	// Use this for initialization
	void Start()
	{
		target = GameObject.Find("target");
	}

	// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(target.transform.position, transform.position) <= 30)
		{
			Quaternion targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);

			shotInterval += Time.deltaTime;
			if (shotInterval > shotIntervalMax)
			{
				Instantiate(shot, transform.position, transform.rotation);
				shotInterval = 0;
			}
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Shot")
		{
			Destroy(gameObject);
			Debug.Log("Destroy");
		}
	}
}
