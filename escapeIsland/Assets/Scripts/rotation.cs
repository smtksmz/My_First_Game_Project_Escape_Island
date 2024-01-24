using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    public float moveSpeed = 3f;
    public float movementRange = 5f;

    private Scene scene;

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
        scene = SceneManager.GetActiveScene();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life.lifes--;
            diamond.point = 0;
            SceneManager.LoadScene(scene.name);
        }
    }
}
