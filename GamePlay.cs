using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GamePlay : MonoBehaviour
{
    public void GoNextScene(string Name)
    {
        SceneManager.LoadScene(Name);
    } 
}
