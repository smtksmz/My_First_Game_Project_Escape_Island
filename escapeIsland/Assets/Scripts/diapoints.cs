using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class diapoints : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private void Awake()
    {
        _text.text = diamond.point.ToString();
    }

    
    void Update()
    {
        _text.text = diamond.point.ToString();
    }
}
