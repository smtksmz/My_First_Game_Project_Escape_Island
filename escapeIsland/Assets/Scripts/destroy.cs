using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {
            diamond.point++;
            collision.gameObject.SetActive(false);
        }
    }
}
