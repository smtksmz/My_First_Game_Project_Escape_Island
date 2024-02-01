using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class truebutton : MonoBehaviour
{
    [SerializeField] SpriteRenderer key;
    [SerializeField] CapsuleCollider2D keycap;
    AudioSource audio1;

    private void Start()
    {
        audio1 = GetComponent<AudioSource>();
        key.GetComponent<SpriteRenderer>().enabled = false;
        keycap.GetComponent<CapsuleCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("stone")) 
       {
            audio1.Play();
            key.GetComponent<SpriteRenderer>().enabled = true;
            keycap.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
}
