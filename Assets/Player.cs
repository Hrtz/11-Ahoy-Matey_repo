using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    private Vector3 move;
	private Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLocalPlayer) {
			return;
		}
		float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        move = (v*Vector3.forward + h*Vector3.right).normalized;
		m_Rigidbody.AddForce(move);
	}

//    private void FixedUpdate()
//    {
//        // Call the Move function of the ball controller
//		m_Rigidbody.AddForce(move);
//    }
}
