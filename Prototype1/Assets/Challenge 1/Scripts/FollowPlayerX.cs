using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new Vector3(0, 5, -15);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
