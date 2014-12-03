using UnityEngine;
using System.Collections;

public class ReconPlayerToGet : MonoBehaviour {
	
	[SerializeField]
	private GameObject objectOnScreen;


	void Start(){

		objectOnScreen.gameObject.SetActive (false);
	}


	void OnTriggerEnter(Collider collider){

		if(collider.tag == "playerTag"){
			/*Cuando el Player se acerca a la llave, llama al metodo 
		 PocketFull que esta en su Script inventario y este pone
		 a true su booleano, esto permitira que pase por la
		 puerta*/
			collider.GetComponent<Inventory>().PocketFull();
			/*objectOnScreen esta desactivado por defecto, cuando
			 se recoge la llave, este metodo hace que la llave 
			 aparezca en la camara principal que cuelga de
			 player de tal forma que el usuario sea consciente de que la llave 
			 esta cogida*/
			objectOnScreen.gameObject.SetActive(true);
			/*Por ultimo destrulle el objeto del que cuelga este Script
			 que en este caos es la llave, dando coherencia a la aparicion
			 de la llave en la pantalla del usuario*/
			Destroy(this.gameObject);
		}
	}
}
