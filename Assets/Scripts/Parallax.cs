using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private GameObject parallaxTarget;


    [Range(0f, 1f)]
    [SerializeField]
    private float speedMultiplier;

    
    void Start()
    {  
    }

    void Update()
    {
        float incrementPosition = this.parallaxTarget.transform.position.x * -this.speedMultiplier;


        float newPositionX = this.parallaxTarget.transform.position.x + incrementPosition;
        float newPositionY = this.transform.position.y;
        float newPositionZ = this.transform.position.z;
        Vector3 newPosition = new Vector3(newPositionX, newPositionY, newPositionZ);

        this.transform.position = newPosition;
    }
}
