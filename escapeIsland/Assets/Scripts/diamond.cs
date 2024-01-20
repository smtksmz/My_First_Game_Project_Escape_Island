using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class diamond : MonoBehaviour
{
    public static SpriteRenderer sprita;
    public static PolygonCollider2D coli;
    

    private void Start()
    {
        sprita = GetComponent<SpriteRenderer>();
        coli = GetComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        sprita.enabled = false;
        coli.enabled = false;
    }
}
