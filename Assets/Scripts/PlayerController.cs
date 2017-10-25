using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {
	[SerializeField] float accumulatedForce = 0;
	[SerializeField] UIManager UIM;
	private Rigidbody rb;
	bool jump = false;
	Vector3 limit;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		//renderer = GetComponent<Renderer> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.Space) && !jump) {
			accumulatedForce += 10;
			//renderer.cubo.color = new Color ((accumulatedForce * 0.01),1,1);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			jump = true;
			Invoke ("resetjump",0.2f); 
		}
		if (limit.y > transform.position.y) {
			transform.parent = null;
			UIM.GameOver ();
		}
		
	}
	private void FixedUpdate(){
		if (jump) {
			rb.AddForce (new Vector3 (-accumulatedForce * 0.1f, accumulatedForce, 0));
		}
	}

	void resetjump(){
		jump = false;
		accumulatedForce = 0;
		//renderer.material.color = new Color (1,1,1);
	}
	void OnCollisionEnter (Collision other){
		UIM.UpdateCounter();
		limit = transform.position + new Vector3 (0,-0.5f,0);

	}

}
