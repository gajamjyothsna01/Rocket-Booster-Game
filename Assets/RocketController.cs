using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class RocketController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private float rocketRotationSpeed;
    [SerializeField]
    private float rocketThrustSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveRocketUp();

    }

    private void moveRocketUp()
    {
        RocketThrust();
        RocketRotate();
        
        /* if (Input.GetKey(KeyCode.A))
         {
             transform.Translate(0f, 0f, 0f);
         }

         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate(0.1f, 0f, 0f);
         }
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(-0.1f, 0f, 0f);
         }
         if (Input.GetKey(KeyCode.UpArrow))
         {
             transform.Translate(0f, 0.1f, 0f);
         } */



    }

    private void OnCollisionEnter(Collision collision)
    {
        //string sceneName = SceneManager.GetActiveScene().name;

        //SceneManager.LoadScene(sceneName);
        if (collision.gameObject.tag == "WallCollision")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void RocketRotate()
    {
        float speed = 100.0f;
        rb.freezeRotation = false;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocketRotationSpeed =speed * Time.deltaTime;

            transform.Rotate(Vector3.forward*rocketRotationSpeed);

            Debug.Log("Forward Rotation");

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocketRotationSpeed = speed* Time.deltaTime;
            transform.Rotate(Vector3.back * rocketRotationSpeed);

            Debug.Log("Backward Rotation");

        }
    }

    private void RocketThrust()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float thrustSpeed = 100.0f;
            rocketThrustSpeed = thrustSpeed * Time.deltaTime;

            rb.AddRelativeForce(Vector3.up * rocketThrustSpeed);
            Debug.Log("Going Up");
        }
    }
}
