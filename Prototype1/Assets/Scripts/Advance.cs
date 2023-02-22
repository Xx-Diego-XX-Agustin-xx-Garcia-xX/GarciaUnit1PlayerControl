using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advance : MonoBehaviour
{
    public int speed;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
