using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    // how much the charcter will move by.
    private Vector3 move;


	// Use this for initialization
	void Start () {
        move = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    // Takes care of
    void Movement()
    {
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        transform.Translate(move);
    }
}
