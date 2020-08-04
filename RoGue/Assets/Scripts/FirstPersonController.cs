using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]


public class FirstPersonController : MonoBehaviour
{

    public float nominalSpeed = 6.0f, speed;
    private CharacterController _charController;

    public float gravity = -9.8f;


    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("space"))
        {
            //jump
            Jump();
        }
        if (Input.GetKeyDown("left shift"))
        {
            speed = nominalSpeed * 1.5f;
        }
        if(Input.GetKeyUp("left shift"))
        {
            speed = nominalSpeed;
        }
        float deltax = Input.GetAxis("Horizontal") * speed;
        float deltaz = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltax, 0, deltaz);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        
    }

    void Jump()
    {
        //grants ability to jump

    }
}
