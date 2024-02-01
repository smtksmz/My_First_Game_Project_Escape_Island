using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrongbutton : MonoBehaviour
{
    public static int chance = 2;
    AudioSource audio2;

    private void Awake()
    {
        audio2 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("stone"))
        {
            audio2.Play();
            chance--;
        }
        if(chance==0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
