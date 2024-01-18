using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private GameObject parallaxTarget;
    private Rigidbody2D rb2D;

    [Range(0f, 1f)]
    [SerializeField]
    private float speedMultiplier;

    
    void Start()
    {
        this.rb2D = this.GetComponent<Rigidbody2D>();    
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
