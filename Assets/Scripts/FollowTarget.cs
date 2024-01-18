using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    void Update()
    {
        this.transform.position = this.target.position;
    }
}
