using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resource : MonoBehaviour
{
    public Text resText;
    float res = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        res += Time.deltaTime;
        int show = (int) res;
        resText.text = show.ToString() + "s";
    }
}
