using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class truebutton : MonoBehaviour
{
    [SerializeField] GameObject key;

    private void Start()
    {
        key.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("stone")) 
       {
            key.SetActive(true);
       }
    }
}
