using UnityEngine;
using System.Collections;

public class StartElevator : MonoBehaviour {

	private GameObject elevator;
	private ElevatorUpDown elevatorUpDown;

	// Use this for initialization
	void Start () {
		/*Aqui en lugar de serializarlo lo que hacemos es que
		 buscamos con Find el objeto Elevador y lo asignamos
		 al campo elevator y en elevatorUpDown llamo a ese
		 objeto elevador ya encontrado para coger el Script
		 ElevatorUpDown el cua ltiene los metodos que se usan
		 en los metodos SendElevatorDown SendElevatorUp*/
		elevator = GameObject.Find("Elevator") as GameObject;
		elevatorUpDown = elevator.GetComponent<ElevatorUpDown>();
	}
	/*Este es el metodo que usaremos dentro de los eventos
	 y que asignan a diferentes momentos de la naimcacion boton la
	 accion a realizar, en este caso enviar el elevador
	 arriba*/
	private void SendElevatorDown(){

		elevatorUpDown.Down();
	}
	/*Este es el metodo que usaremos dentro de los eventos
	 y que asignan a diferentes momentos de la naimcacion boton la
	 accion a realizar, en este caso enviar el elevador
	 abajo*/
	private void SendElevatorUp(){
		elevatorUpDown.Up ();
	}
}
