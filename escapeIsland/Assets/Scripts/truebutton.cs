using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class truebutton : MonoBehaviour
{
    [SerializeField] SpriteRenderer key;
    [SerializeField] CapsuleCollider2D keycap;

    private void Start()
    {
        key.GetComponent<SpriteRenderer>().enabled = false;
        keycap.GetComponent<CapsuleCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("stone")) 
       {
            key.GetComponent<SpriteRenderer>().enabled = true;
            keycap.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
}
