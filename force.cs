using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
   
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        int speed = 30;
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 30f), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "pickup")
            rb.AddForce(new Vector3(0, 0), ForceMode.Force);
    }
}
