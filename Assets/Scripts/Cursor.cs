using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Transform target;

	public MeshRenderer curOne;
	public MeshRenderer curTwo;

	public void SetSelected (bool selected)
	{
		curOne.material.SetColor ("_Color", (selected) ? Color.green : Color.white);
		curTwo.material.SetColor ("_Color", (selected) ? Color.green : Color.white);
	}

	void Update()
	{
		transform.LookAt(target);
	}
}
