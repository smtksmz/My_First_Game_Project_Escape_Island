using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class traps : MonoBehaviour
{
    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life.lifes--;
            diamond.point = 0;
            wrongbutton.chance = 2;
            SceneManager.LoadScene(_scene.name);
        }
        if(life.lifes==0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
