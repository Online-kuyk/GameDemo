using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ComeBack : MonoBehaviour
{
    public void GoScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
