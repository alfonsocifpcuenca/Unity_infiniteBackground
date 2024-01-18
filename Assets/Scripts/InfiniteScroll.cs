using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{

    [SerializeField]
    private int backgroundPosition;
    private int currentPosition;

    [SerializeField]
    private Camera camera;

    private float cameraWidth;

    private void Awake()
    {
        if (this.camera != null)
        {
            this.currentPosition = this.backgroundPosition;

            this.cameraWidth = camera.orthographicSize * 2f * camera.aspect;
            SetBackgroundPosition();
        }
    }

    private void SetBackgroundPosition()
    {
        var newPositionX = this.cameraWidth * this.currentPosition;
        var newPositionY = this.transform.localPosition.y;
        var newPositionZ = this.transform.localPosition.z;
        var newPosition = new Vector3(newPositionX, newPositionY, newPositionZ);
        this.transform.localPosition = newPosition;
    }

    void Update()
    {
        
        float distance = this.camera.gameObject.transform.position.x - this.transform.position.x;
        if (distance > (this.cameraWidth * 1.5))
        {
            this.currentPosition += 3; 
            SetBackgroundPosition();
        }

        if (distance < -(this.cameraWidth * 1.5))
        {
            this.currentPosition -= 3;
            SetBackgroundPosition();
        }
        
    }
}
