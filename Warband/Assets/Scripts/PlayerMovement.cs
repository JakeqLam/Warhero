using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float runSpeed = 40f;
    public CharacterController2D controller;
    public Animator animator;

    float horizontalmove = 0f;

    //Update can be updated to have jump or crouch. For reference watch Brackeys
	// Update is called once per frame
	void Update () {
        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;
	}

    void FixedUpdate() {
        //move our Character
        controller.Move(horizontalmove * Time.fixedDeltaTime , false, false);
    }
}
