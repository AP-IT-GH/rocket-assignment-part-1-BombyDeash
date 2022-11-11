using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketUserControl : MonoBehaviour
{
    private Rigidbody rocket;
    private float thrust;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rocket = GetComponent<Rigidbody>();
        thrust = 1500f;
        rotationSpeed = 150f;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //Apply forward force when space, z or up key is held down
        if (Input.GetKey("space") || Input.GetKey("z") || Input.GetKey("up"))
        {
            rocket.AddRelativeForce(new Vector3(0, thrust * Time.deltaTime, 0), ForceMode.Force);
        }

        //Rotate left when Q or left key is held down
        if (Input.GetKey("q") || Input.GetKey("left"))
        {
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, 0, -rotationSpeed) * Time.deltaTime);
            rocket.MoveRotation(rocket.rotation * deltaRotation);
            rocket.angularVelocity = Vector3.zero;
        }

        //Rotate right when d or right key is held down
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
            rocket.MoveRotation(rocket.rotation * deltaRotation);
            rocket.angularVelocity = Vector3.zero;
        }
       
    }
}
