using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D rb2D;

    private void Start()
    {
        this.rb2D = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        Vector3 newVelocity = new Vector3(moveX * this.moveSpeed, 0, 0);
        this.rb2D.velocity = newVelocity;
    }
}
