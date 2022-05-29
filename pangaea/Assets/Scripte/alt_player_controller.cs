using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

 private CharacterController controller;
    public float speed = 10f;

    Vector3 velocity;

    public float gravity = -9.81f; // -9.81f ist die Gravitation

    public float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //bewegen
        Vector3 richtung = transform.right * x + transform.forward * z;
        controller.Move(richtung * speed * Time.deltaTime); 

        //springen
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //check is ground
        if(velocity.y < 0 && controller.isGrounded)
        {
            velocity.y = -2f;
        }
        //springen aktiv
        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        
    }
}
