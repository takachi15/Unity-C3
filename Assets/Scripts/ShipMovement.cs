using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 WorldPosition;
    [SerializeField] protected float speed = 0.1f;
    void FixedUpdate()
    {
        this.WorldPosition = InputManager.Instance.MouseWorldPos;
        this.WorldPosition.z = 0;
        Vector3 newPos = Vector3.Lerp(transform.parent.position, WorldPosition,speed);
        transform.parent.position = newPos;
        
    }
}
