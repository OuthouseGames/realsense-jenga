using UnityEngine;
using System.Collections;

public class RotateLeft : MonoBehaviour 
{

	public float moveSpeed = 10f;
	public RotateRight rotateRight;
	
	void Update() 
	{
		this.gameObject.transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);
	}
	void OnEnable() 
	{
		//Debug.Log ("Rotate enabled");
		rotateRight.enabled = !rotateRight.enabled;
	}
	
	void OnDisable() 
	{
		//Debug.Log ("Rotate Disabled");
	}
}
