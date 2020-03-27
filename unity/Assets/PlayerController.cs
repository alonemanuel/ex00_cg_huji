using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementForce = 500; // Controls player movement power
    private Rigidbody body;


    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        arrowKeysHandler();
        // Implement movement logic here
    }

    void arrowKeysHandler()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector3.back;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.left;
        }

        if (direction != Vector3.zero)
        {
            body.AddForce(direction * movementForce * Time.deltaTime);
        }
    }
}