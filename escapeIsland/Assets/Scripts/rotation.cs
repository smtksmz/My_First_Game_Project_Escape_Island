using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    public float moveSpeed = 3f;
    public float movementRange = 5f;

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }
   

    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        MoveAutomatically();
    }

    void MoveAutomatically()
    {
        Vector3 movement = new Vector3(Mathf.PingPong(Time.time * moveSpeed, movementRange * 2) - movementRange, 0f, 0f);
        transform.position = startingPosition + movement;
    }
}
