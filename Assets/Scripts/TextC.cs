using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextC : MonoBehaviour
{
    public GameObject TX;
    float re, gr, bl;
    float sp=-0.02f;
    void Start()
    {
      re  = TX.GetComponent<Text>().color.r;
      gr  = TX.GetComponent<Text>().color.g;
      bl  = TX.GetComponent<Text>().color.b;
    }

    void Update()
    {
        float al = this.TX.GetComponent<Text>().color.a;
        if (al < 0 || al > 1)
            sp *= -1;
        this.TX.GetComponent<Text>().color = new Color(re, gr, bl, al+sp);
    }
}
