using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerControll : MonoBehaviour
{
	public float speed = 6.0F;
	public float jumpSpeed = 20.0F;
	public float gravity = 20.0F;
	public float gravityForce = 3.0f;
	public float airTime = 2f;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	private float forceY = 0;
	private float invertGrav;


	void Start()
	{
		invertGrav = gravity * airTime;
		controller = GetComponent<CharacterController>();
	}
	void Update()
	{
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		if (controller.isGrounded)
		{
			forceY = 0;
			invertGrav = gravity * airTime;
			if (Input.GetButtonDown("Jump"))
			{
				// we jump 
				forceY = jumpSpeed;
			}
		}
		if (Input.GetButton("Jump") && forceY != 0)
		{
			invertGrav -= Time.deltaTime;
			forceY += invertGrav * Time.deltaTime;
		}
		forceY -= gravity * Time.deltaTime * gravityForce;
		moveDirection.y = forceY;
		controller.Move(moveDirection * Time.deltaTime);


	}
}