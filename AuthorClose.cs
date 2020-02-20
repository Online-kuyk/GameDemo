using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuthorClose : MonoBehaviour
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

    // Update is called once per frame
    public void AuthorTT()
    {
        Au_Image.GetComponent<Image>().enabled =false;
        Au_Text.GetComponent<Text>().enabled = false;
        Btn.GetComponent<Image>().enabled = false;
        Btn_Text.GetComponent<Text>().enabled = false;
        MAP_Image.GetComponent<Image>().enabled = false;
        MAP_Text.GetComponent<Text>().enabled = false;
    }
}
