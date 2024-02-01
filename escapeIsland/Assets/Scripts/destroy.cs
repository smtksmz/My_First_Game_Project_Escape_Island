using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using System.Reflection;

public class destroy : MonoBehaviour
{
    AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {
            _audio.Play();
            diamond.point++;
            collision.gameObject.SetActive(false);
        }
    }
}
