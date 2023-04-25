using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] private bool isRotating = false;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateDirection;

    // Update is called once per frame
    void Update()
    {
        if (isRotating) transform.Rotate(rotateSpeed * rotateDirection * Time.deltaTime);
    }
}
