using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float movementSpeed = 5f;


    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //transform.position = new Vector3(transform.position.x + horizontalInput * Time.deltaTime * movementSpeed, transform.position.y, transform.position.z + verticalInput * Time.deltaTime * movementSpeed);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward;
        }

    }
}
