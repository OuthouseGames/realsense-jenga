using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("return"))
		{
			//Debug.Log("Load Level");
			Application.LoadLevel ("Jenga");
		}
	}
}
