using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chapter2pass : MonoBehaviour
{
    private CapsuleCollider2D capcoll;
    private Scene scene1;
    private void Start()
    {
        scene1 = SceneManager.GetActiveScene();
        capcoll = GetComponent<CapsuleCollider2D>();
        capcoll.enabled = false;
    }

    private void Update()
    {
      if (diamond.point == 6)
      {
        capcoll.enabled = true;
      }   
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene1.buildIndex + 1);
        }
    }
}
