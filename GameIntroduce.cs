using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIntroduce : MonoBehaviour
{
    GameObject A_Img;
    GameObject B_Img;
    GameObject A_Text;
    GameObject B_Text;
    GameObject Btn_Close;
    GameObject Btn_Text;
    void Start()
    {
        A_Img = GameObject.Find("A-Image");
        B_Img = GameObject.Find("B-Image");
        A_Text = GameObject.Find("A-Text");
        B_Text = GameObject.Find("B-Text");
        Btn_Close = GameObject.Find("BtnClose");
        Btn_Text = GameObject.Find("BtnText");
    }
    public void Introduce() 
    {
        A_Img.GetComponent<Image>().enabled = true;
        B_Img.GetComponent<Image>().enabled = true;
        A_Text.GetComponent<Text>().enabled = true;
        B_Text.GetComponent<Text>().enabled = true;
        Btn_Close.GetComponent<Image>().enabled = true;
        Btn_Text.GetComponent<Text>().enabled = true;
    }
}
