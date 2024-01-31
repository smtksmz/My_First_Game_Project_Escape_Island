using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chapter2coll : MonoBehaviour
{
    private Scene scene1;
    private void Start()
    { 
        scene1 = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene1.buildIndex + 1);
        }
    }
}
