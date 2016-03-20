using UnityEngine;
using System.Collections;

public class CameraCOntroller : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame but guaranteed after all items have been processed in update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
