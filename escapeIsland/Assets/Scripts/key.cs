using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    [SerializeField] private CapsuleCollider2D passcol;
    private SpriteRenderer keydisrend;
    private CapsuleCollider2D keydiscap;

    private void Start()
    {
        passcol.GetComponent<CapsuleCollider2D>().enabled = false;
        keydisrend =GetComponent<SpriteRenderer>();
        keydiscap=GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           passcol.GetComponent<CapsuleCollider2D>().enabled = true;
           keydisrend.enabled = false;
           keydiscap.enabled = false;
           
        }
    }
}
