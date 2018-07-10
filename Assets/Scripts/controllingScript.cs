using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
	public class controllingScript : MonoBehaviour {
		public Platformer2DUserControl ctrl;
		public GameObject player;
		public TextMesh answer,correct,wrong;
		public Text challenge, time;
		private int num1,num2,ans,difficulty;
		private bool animCorrect,animWrong,finished;
		public static float prevTime=0;
		// Use this for initialization
		void Start () {
			difficulty = 4;
			num1 = generateRandomOperand ();
			num2 = generateRandomOperand ();
			ans = num1 * num2;
			challenge.text = num1 + "x" + num2;


			
		}
			

		int generateRandomOperand(){
			return Random.Range (1, difficulty);
		}

		void FixedUpdate(){
			if(player.transform.position.x > 200 && finished==false){
				//EditorUtility.DisplayDialog ("Finished!","You finished in " + (Time.time - prevTime).ToString ("0.##") + " seconds","Play again","Cancel");
				finished = true;
				reset ();
			}
		}



		void reset(){
			prevTime = Time.time;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			ctrl.stop ();
		}

		// Update is called once per frame
		void Update () {

			if(Input.GetKeyDown (KeyCode.R)){
				reset ();

			}

			time.text = "Time: " + (Time.time - prevTime).ToString ("0.##");
			if(answer.text.Length > 2){
				answer.text="";
				animWrong = true;

			}
			else if(answer.text== ans.ToString()){
				answer.text="";
				animCorrect = true;
				ctrl.impulse ();
				num1 = generateRandomOperand ();
				num2 = generateRandomOperand ();
				ans = num1 * num2;

				challenge.text = num1 + "x" + num2;

			}


			if(animCorrect){
				if(correct.fontSize > 1){
					correct.text = "CORRECT";
					correct.fontSize -= 1;
				}
				else{
					animCorrect = false;
					correct.text= "";
					correct.fontSize = 60;
				}
			}
			if(animWrong){
				if(wrong.fontSize > 1){
					wrong.text = "WRONG";
					wrong.fontSize -= 1;
				}
				else{
					animWrong = false;
					wrong.text= "";
					wrong.fontSize = 60;
				}
			}

		}
	}
}