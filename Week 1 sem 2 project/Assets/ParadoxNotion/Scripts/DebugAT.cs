using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class DebugAT : ActionTask {



		
		
		
		
		
		
		
		
		
		
		
		
		
		
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise

		protected override string OnInit() {

			//This runs only the first time the noder is being called
			//can be used to set values (as start)
			//can also be used to spawn some monster
			//randomize value
			//Get a value or data from an object

			Debug.Log("Debug is initialized");
			
			
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//This is called everytimethe node is called (kind of like on enable)
			//Can be used as a default state that need to run once


			Debug.Log("debug is executing");


			//This has to be at the end of the script to indicate that the action is done
			//EndAction(true);

		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

		
			if (Input.GetKeyDown(KeyCode.A))
			{
				Debug.Log("Beans");
				EndAction(true);
			}
			/*agent.transform.position += agent.transform.position * 3f * Time.deltaTime;
			Rigidbody rb = agent.GetComponent<Rigidbody>();
			agent.gameObject.SetActive(true);*/




			//Debug.Log("Debug is updating");

		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}