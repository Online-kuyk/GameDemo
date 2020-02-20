using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Author : MonoBehaviour
{
    GameObject Au_Image;
    GameObject Au_Text;
    GameObject Btn;
    GameObject Btn_Text;
    GameObject MAP_Image;
    GameObject MAP_Text;

    void Start()
    {
        Au_Image = GameObject.Find("Author-Image");
        Au_Text = GameObject.Find("Author-Text");
        Btn = GameObject.Find("Btn-Close");
        Btn_Text = GameObject.Find("Btn-Text");
        MAP_Image = GameObject.Find("MAP");
        MAP_Text = GameObject.Find("MAPText");
    }
    public void AuthorTH()
    { 
        Au_Image.GetComponent<Image>().enabled = true;
        Au_Text.GetComponent<Text>().enabled = true;
        Btn.GetComponent<Image>().enabled = true;
        Btn_Text.GetComponent<Text>().enabled = true;
        MAP_Image.GetComponent<Image>().enabled = true;
        MAP_Text.GetComponent<Text>().enabled = true;
   }
}
