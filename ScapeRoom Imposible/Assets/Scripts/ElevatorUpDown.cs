using UnityEngine;
using System.Collections;

public class ElevatorUpDown : MonoBehaviour {

	private GameObject elevator;
	private Animation updAndDown;
	private float y ;
	
	void Start () {
		elevator = GameObject.Find("ElevatorMovement") as GameObject;
		updAndDown = elevator.GetComponent<Animation>();
	}
	
	public void Up(){
		y = elevator.transform.position.y;
		if (y >= 0) {
			updAndDown.Play ("elevatorUp");
		}
	}

	public void Down(){
		y = elevator.transform.position.y;
		if(y >= 3.4){
		updAndDown.Play("elevatorDown");
		}
	}

	private void OnTriggerExit(Collider collider){
		y = elevator.transform.position.y;
		if(collider.name == "Player" && y > 0){

				Down ();

		}
		
	}




}
