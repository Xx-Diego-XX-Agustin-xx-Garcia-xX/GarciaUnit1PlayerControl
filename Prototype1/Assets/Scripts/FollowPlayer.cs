using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 5, -15);
    public GameObject player;
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
