using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_schiessen : MonoBehaviour
{

    public float bulletSpeed = 8000;
    public float bulletSelfdestruct = 5.0f;
    public GameObject bullet;

    /* add component audio source to the object */
    //AudioSource bulletAudio;

    // Use this for initialization
    void Start()
    {

        //bulletAudio = GetComponent<AudioSource>();

    }

    void Fire()
    {
        //Shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, bulletSelfdestruct); //0.5f

        //Play Audio
        //bulletAudio.Play();

    }


    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(transform.position, transform.forward * bulletSpeed, Color.red);

        if (Input.GetMouseButtonDown(0))
        //if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }

    }

}
