using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GoBack : MonoBehaviour
{
    public void GoScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
