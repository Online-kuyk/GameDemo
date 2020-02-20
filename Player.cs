using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Transform m_Transform;
    GameObject Audio_TT;
    private Text Text_Count;
    void Start()
    {
        m_Transform = gameObject.GetComponent<Transform>();
        Audio_TT = GameObject.Find("AudioSource");
        Text_Count = GameObject.Find("Count").GetComponent<Text>();
    }
    protected bool paused;
    void OnPauseGame()
    {
        paused = true;
    }
    void OnResumeGame()
    {
        paused = false;
    }
    float t;

    void Update()
    {
        if (!paused)
        {
            int s = int.Parse(Text_Count.text);
            Text_Count.text = (s + 1).ToString();
            m_Transform.transform.Translate(Vector3.forward * 0.2f, Space.Self);
            if (Input.GetKeyUp(KeyCode.A))
            {
                m_Transform.transform.Translate(Vector3.left * 2, Space.Self);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                m_Transform.transform.Translate(Vector3.right * 2, Space.Self);
            }
            if (Input.GetKeyUp(KeyCode.Q))
            {
                m_Transform.Rotate(Vector3.up, -90);
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                m_Transform.Rotate(Vector3.up, 90);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Transform.transform.Translate(Vector3.up * 2.5f, Space.Self);
                m_Transform.transform.Translate(Vector3.forward * 0.3f, Space.Self);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Audio_TT.GetComponent<AudioSource>().Pause();
                t = Audio_TT.GetComponent<AudioSource>().time;
                Object[] objects = FindObjectsOfType(typeof(GameObject));
                foreach (GameObject go in objects)
                {
                    go.SendMessage("OnPauseGame", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Object[] objects = FindObjectsOfType(typeof(GameObject));
                Audio_TT.GetComponent<AudioSource>().Play();
                Audio_TT.GetComponent<AudioSource>().time = t;
                foreach (GameObject go in objects)
                {
                    go.SendMessage("OnResumeGame", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
