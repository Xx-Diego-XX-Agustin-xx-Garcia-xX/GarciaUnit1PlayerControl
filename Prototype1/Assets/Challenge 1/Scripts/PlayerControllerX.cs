using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
