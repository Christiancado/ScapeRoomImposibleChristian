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

	/*Condiciona el objeto ElevatorMovement para que solo suba si esta en una posicion 
	 menor o igual que 3.4 que es la altura maxima a la que se eleva*/
	public void Up(){
		y = elevator.transform.position.y;
		if (y >= 0 && y <= 3.4) {

			updAndDown.Play ("elevatorUp");
		}
	}


	/*Se asegura que el ascensor solo baje si se encuentra a una altura mayor o igual
	 que el tope al que debe llegar*/
	public void Down(){
		y = elevator.transform.position.y;
		if(y >= 3.4){
		updAndDown.Play("elevatorDown");
		}
	}

	/*Me aseguro de que el objeto baje cuando el personaje salga del trigger
	 , es decir, cuando llegue arriba del todo siempre y cuando el ascensor
	 no este ya abajo*/
	private void OnTriggerExit(Collider collider){
		y = elevator.transform.position.y;
		if(collider.name == "Player" && y > 0){

				Down ();

		}
		
	}




}
