using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.name == "Player")
		{
			SceneManager.LoadScene("gameover");
		}
	} 
}
