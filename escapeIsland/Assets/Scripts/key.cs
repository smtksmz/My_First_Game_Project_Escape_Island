using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    [SerializeField] private CapsuleCollider2D passcol;
    private GameObject keyenable;

    private void Start()
    {
        keyenable=GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           passcol.GetComponent<CapsuleCollider2D>().enabled = true;
           keyenable.SetActive(false);
        }
    }
}
