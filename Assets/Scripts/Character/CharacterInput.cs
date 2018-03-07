using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotSpeed = 10.0F;
    private Vector3 moveDirection = Vector3.zero;

    public Gun currGun;
    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        currGun = GetComponentInChildren<Gun>();
    }
    void Update()
    {
        //handles the movement
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //handles the shooting
        if (Input.GetButtonDown("Fire1"))
        {
            currGun.Fire();
        }
    }

    void OnTriggerStay(Collider other)
    {
        //handles interacting with Interactable objects
        if (Input.GetButton("Interact"))
        {
            other.GetComponent<Interactable>().Interact(gameObject);
        }
    }
}
