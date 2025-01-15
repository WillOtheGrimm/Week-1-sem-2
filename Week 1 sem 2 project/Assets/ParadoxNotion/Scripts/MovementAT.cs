using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MovementAT : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		public float speed;
		protected override string OnInit() {
			//Debug.Log("I am moving!");
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            if (Input.GetKey(KeyCode.W) )
            {
				agent.transform.position += Vector3.forward * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                agent.transform.position += Vector3.back * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                agent.transform.position += Vector3.left * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                agent.transform.position += Vector3.right * speed * Time.deltaTime;
            }

			if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
                {
				EndAction(true);
                }

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}