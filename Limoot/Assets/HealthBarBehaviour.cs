using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarBehaviour : MonoBehaviour
{
    public Slider Slider;
    public Color low;
    public Color high;
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
}
