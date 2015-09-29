using UnityEngine;
using System.Collections;

public class RotateRight : MonoBehaviour {

	public float moveSpeed = 10f;
	public RotateLeft rotateLeft;

	void Update() 
	{
		this.gameObject.transform.Rotate(Vector3.up * -moveSpeed * Time.deltaTime);
	}
	void OnEnable() 
	{
		//Debug.Log ("Rotate enabled");
		rotateLeft.enabled = !rotateLeft.enabled;
	}
	
	void OnDisable() 
	{
		//Debug.Log ("Rotate Disabled");
	}
}
