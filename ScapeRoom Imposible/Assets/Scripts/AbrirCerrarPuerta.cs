using UnityEngine;
using System.Collections;

public class AbrirCerrarPuerta : MonoBehaviour {

	[SerializeField]
	private GameObject ejePuerta;
	private Animation animacionPuerta;
	[SerializeField]
	private GameObject player;
	private Inventory inventory;



	void Start () {
		/*Cojo la animacion de del objeto puerta que es el que se va a 
		 *mover y que esta previamente serializado de forma que tengamos 
		 *las animaciones listas para ser ejecutadas*/
		animacionPuerta = ejePuerta.GetComponent<Animation>();

		/*Cojo el Script Inventory que cuelga de Player (el cual 
		 esta debidamente serializado) y lo metemos en el campo
		 inventory para que cuando Player entre en el Trigger
		 este pueda preguntarle si tiene la llave*/
		inventory = player.GetComponent<Inventory>();

	}
	
	void OnTriggerEnter(){
		/*Pregunta si se tiene la llave y ejecuta la animacion de 
		 openDoor*/

		if(inventory.GetPocket()){
			animacionPuerta.Play ("openDoor");
		}

	}

	void OnTriggerExit(){
		/*Pregunta si se tiene la llave y ejecuta la animacion de 
		 closeDoor*/

		if(inventory.GetPocket()){
			animacionPuerta.Play ("closeDoor");
		}

	}
}
