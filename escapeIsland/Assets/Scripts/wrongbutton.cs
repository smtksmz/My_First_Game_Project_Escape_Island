using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrongbutton : MonoBehaviour
{
    public static int chance = 2;
   
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("stone"))
        {
            chance--;
            Debug.Log(chance);
        }
        if(chance==0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
