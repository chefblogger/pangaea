using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_cam : MonoBehaviour
{


    public Transform player;
    public float xRotation;
    public float yRotation;
    public float MausSensitivität = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update() 
    {
       float mouseX = Input.GetAxis("Mouse X") * MausSensitivität;
        float mouseY = Input.GetAxis("Mouse Y") * MausSensitivität; 

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //transform.localRotation = player.Rotate(Vector3.up * mouseX);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        player.rotation = Quaternion.Euler(0, yRotation, 0);
    }





}
