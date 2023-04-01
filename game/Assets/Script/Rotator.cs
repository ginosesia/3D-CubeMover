using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateDirection;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * rotateDirection * Time.deltaTime);
    }
}
