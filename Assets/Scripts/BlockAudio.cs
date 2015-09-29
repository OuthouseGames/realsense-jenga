using UnityEngine;
using System.Collections;

public class BlockAudio : MonoBehaviour {

	public AudioSource blockAudio;
	public GameObject ground;
	
	void OnCollisionEnter(Collision collision) 
	{
		if (collision.relativeVelocity.magnitude > 2 && collision.gameObject == ground)
			blockAudio.Play();
	}
}
