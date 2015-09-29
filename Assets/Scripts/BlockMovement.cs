using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour 
{
	public GameObject block;
	public float quietVol = 0.75f;
	public float regularVol = 1.0f;
	public float changeSpeed = 0.25f;
	public AudioSource gameAudio;
	public Cursor cursor;

	void OnTriggerEnter (Collider other)
	{
		if (this.enabled && block == null) 
		{
			cursor.SetSelected (true);
			block = other.gameObject;
			block.transform.parent = this.transform;
			Rigidbody blockRigidBody = block.GetComponent<Rigidbody>();
			blockRigidBody.useGravity = false;
			blockRigidBody.isKinematic = true;
			//Debug.Log("Block Parent = " + block.transform.parent);
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (this.enabled && block == null) 
		{
			cursor.SetSelected (true);

			block = other.gameObject;
			block.transform.parent = this.transform;
			Rigidbody blockRigidBody = block.GetComponent<Rigidbody>();
			blockRigidBody.useGravity = false;
			blockRigidBody.isKinematic = true;
			FadeOut(0.75f);
			//Debug.Log("Block Parent = " + block.transform.parent);
		}
	}

	void OnDisable() 
	{
		if (block) 
		{
			cursor.SetSelected (false);
			Rigidbody blockRigidBody = block.GetComponent<Rigidbody>();
			block.transform.parent = null;
			blockRigidBody.useGravity = true;
			blockRigidBody.isKinematic = false;
			block = null;
			FadeIn(1.0f);
		}
	}

	void OnEnable() 
	{
		//Debug.Log ("Grab Enabled");
	}
	//for Audio
	void FadeOut(float volume)
	{
		while (gameAudio.volume > quietVol) 
		{
			gameAudio.volume -= changeSpeed * Time.deltaTime;
		}

	}
	//for Audio
	void FadeIn(float volume)
	{
		while (gameAudio.volume < regularVol) 
		{
			gameAudio.volume += changeSpeed * Time.deltaTime;
		}
	}

}
