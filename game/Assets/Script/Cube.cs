using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float movementSpeed = 5f;
    [SerializeField] private Rigidbody rigidbody;

    // Update is called once per frame
    void Update()
    {

        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        //transform.position = new Vector3(transform.position.x + horizontalInput * Time.deltaTime * movementSpeed, transform.position.y, transform.position.z + verticalInput * Time.deltaTime * movementSpeed);

        //Ray ray = new Ray(gameObject.transform.position, gameObject.transform.forward);

        //Debug.DrawLine(gameObject.transform.position, gameObject.transform.forward, Color.green);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);

            if (CheckForWall(forward))
            {
                return;
            } else
            {
                rigidbody.MovePosition(transform.position += Vector3.forward);
                IncreaseMoveCount();
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 back = transform.TransformDirection(Vector3.back);

            if (CheckForWall(back))
            {
                return;
            }
            else
            {
                rigidbody.MovePosition(transform.position += Vector3.back);
                IncreaseMoveCount();
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 left = transform.TransformDirection(Vector3.left);

            if (CheckForWall(left))
            {
                return;
            }
            else
            {
                rigidbody.MovePosition(transform.position += Vector3.left);
                IncreaseMoveCount();
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 right = transform.TransformDirection(Vector3.right);

            if (CheckForWall(right))
            {
                return;
            }
            else
            {
                rigidbody.MovePosition(transform.position += Vector3.right);
                IncreaseMoveCount();
            }
        }
    }


    private bool CheckForWall(Vector3 direction)
    {
        if (Physics.Raycast(transform.position, direction, 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    private void IncreaseMoveCount()
    {
        Global.moveCount++;
    }


}
