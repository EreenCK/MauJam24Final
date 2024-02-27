using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class takeSliderValue : MonoBehaviour
{

    public Text text;
    public Slider slider;

    private void Start()
    {
        slider = gameObject.GetComponentInParent<Slider>();
    }

    private void Update()
    {
        text.text = $"{Convert.ToString((int)slider.value)}";
    }
}
