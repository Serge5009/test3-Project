using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontalMovement * speed;

        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += Vector3.up * verticalMovement * speed;
    }
}
