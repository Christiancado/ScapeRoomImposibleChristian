using UnityEngine;
using System.Collections;

public class TransportPlayerUp : MonoBehaviour {

	[SerializeField]
	private GameObject player;


	/*Serializamos a Player para poder convertir su posicion*/
	private void OnTriggerEnter(Collider collider){
		/*Cuando el collider sea el jugador entra en la condicion*/
		if(collider.name == "Player"){
			/*Cojo todos los datos de la posicion del player
			 y a la posicion Y (que es la que deseo modificar) le 
			 sumo la altura a la que se encuentra el personaje
			 en el pasillo inferior, para que el
			 personaje se quede en una altura relativa identica 
			 del de abajo sin que se note*/
			float x = player.transform.position.x;
			float altura = (float)3.52;
			float y = player.transform.position.y + altura;
			float z = player.transform.position.z;
			/*Se lo asigno por medio de variables sueltas
			 debido a que de esta forma no hace ningun trompicon*/
			player.transform.position = new Vector3(x, y, z);

		}
	
	}

}
