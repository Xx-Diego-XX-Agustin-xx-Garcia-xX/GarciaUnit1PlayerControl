using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 36.0f;
    public float turnSpeed = 36.0f;
    private float horizontalInput;
    private float verticalInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
