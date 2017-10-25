using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
		[SerializeField]Text Score;
		[SerializeField]Text Gameover;
		[SerializeField]Image RedPlane;
		int counter = -1;

		void Start () {

		}

		public void UpdateCounter () {
			counter += 1;
			Score.text = "Score: " + counter;
		}
		public void GameOver (){
		Gameover.enabled = true;
		RedPlane.enabled = true;
		}

}
