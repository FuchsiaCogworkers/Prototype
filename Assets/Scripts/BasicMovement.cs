using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public Camera cam;
    private Quaternion rotate = Quaternion.identity;

    private void Start()
    {
    }
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //transform.rotation = Quaternion.Euler(cam.transform.rotation.x, cam.transform.rotation.y, transform.rotation.z);
        //transform.rotation = cam.transform.rotation.x;

    //    //Get the Screen positions of the object
    //    Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

    //    //Get the Screen position of the mouse
    //    Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

    //    //Get the angle between the points
    //    float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

    //    //Ta Daaa
    //    transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    //}

    //float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    //{
    //    return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
