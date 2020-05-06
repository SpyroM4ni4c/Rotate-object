﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class RotateObject : MonoBehaviour
{

	[SerializeField] public float m_rotSpeed = 20;
	public GameObject m_Player;
	Rigidbody rb;
	public Camera m_cam;
	[SerializeField] FirstPersonController m_fpsController;


		void OnMouseDrag()
	{
		if (Input.GetMouseButton(1)) // mouse button key down, if u use GetMouseButtonDown u have to click button many times
		{
			m_fpsController.m_canRotate = false;
			float rotX = Input.GetAxis("Mouse X") * m_rotSpeed * Mathf.Deg2Rad;
			float rotY = Input.GetAxis("Mouse Y") * m_rotSpeed * Mathf.Deg2Rad;

			transform.RotateAround(Vector3.up, -rotX);
			transform.RotateAround(Vector3.right, rotY);

			//m_Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
		



	}

	private void OnMouseUp()
	{
		m_fpsController.m_canRotate = true;
	}






	void Start()
    {
		m_Player.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }
}
