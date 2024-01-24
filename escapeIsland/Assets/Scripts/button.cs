using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] SpriteRenderer diamond1;
    [SerializeField] SpriteRenderer diamond2;
    [SerializeField] SpriteRenderer diamond3;
    [SerializeField] SpriteRenderer diamond4;
    [SerializeField] SpriteRenderer diamond5;
    [SerializeField] SpriteRenderer diamond6;

    [SerializeField] PolygonCollider2D diamond01;
    [SerializeField] PolygonCollider2D diamond02;
    [SerializeField] PolygonCollider2D diamond03;
    [SerializeField] PolygonCollider2D diamond04;
    [SerializeField] PolygonCollider2D diamond05;
    [SerializeField] PolygonCollider2D diamond06;

    private void Start()
    {
        diamond1.GetComponent<SpriteRenderer>().enabled = false;
        diamond2.GetComponent<SpriteRenderer>().enabled = false;
        diamond3.GetComponent<SpriteRenderer>().enabled = false;
        diamond4.GetComponent<SpriteRenderer>().enabled = false;
        diamond5.GetComponent<SpriteRenderer>().enabled = false;
        diamond6.GetComponent<SpriteRenderer>().enabled = false;

        diamond01.GetComponent<PolygonCollider2D>().enabled = false;
        diamond02.GetComponent<PolygonCollider2D>().enabled = false;
        diamond03.GetComponent<PolygonCollider2D>().enabled = false;
        diamond04.GetComponent<PolygonCollider2D>().enabled = false;
        diamond05.GetComponent<PolygonCollider2D>().enabled = false;
        diamond06.GetComponent<PolygonCollider2D>().enabled = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("stone"))
        {
            diamond1.GetComponent<SpriteRenderer>().enabled = true;
            diamond2.GetComponent<SpriteRenderer>().enabled = true;
            diamond3.GetComponent<SpriteRenderer>().enabled = true;
            diamond4.GetComponent<SpriteRenderer>().enabled = true;
            diamond5.GetComponent<SpriteRenderer>().enabled = true;
            diamond6.GetComponent<SpriteRenderer>().enabled = true;

            diamond01.GetComponent<PolygonCollider2D>().enabled = true;
            diamond02.GetComponent<PolygonCollider2D>().enabled = true;
            diamond03.GetComponent<PolygonCollider2D>().enabled = true;
            diamond04.GetComponent<PolygonCollider2D>().enabled = true;
            diamond05.GetComponent<PolygonCollider2D>().enabled = true;
            diamond06.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
