using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private Text Text_Count;
    void Start()
    {
        Text_Count = GameObject.Find("Count").GetComponent<Text>();
    }

    void FixedUpdate()
    {
        int s = int.Parse(Text_Count.text);
        Text_Count.text = (s + 1).ToString();
    }
}
