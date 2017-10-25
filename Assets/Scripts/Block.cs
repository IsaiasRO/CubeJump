using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	[SerializeField] GameObject block;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		float rnx = Random.Range(-1.5f,-4f);
		float rny = Random.Range(1.5f,4f);
		Vector3 newPos = transform.position + new Vector3 (rnx, rny, 0f);
		Instantiate (block, newPos, Quaternion.identity);


	}
	void OnTriggerExit (Collider other){
		Destroy (gameObject);
	}
}
