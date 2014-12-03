using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	[SerializeField]
	private bool namePocket = false; 

	void Start(){
		namePocket = false;
	}

	/*Determina que cuando uno se acerca a la llave esta es 
	 cogida, este metodo sera llamado desde llave*/
	public void PocketFull(){
		namePocket = true;
	}

	/*Este lo usaremos para desde puerta llamar a la variable
	 namePocket, si esta a true este se encargara de abrir la puerta
	 si esta a false significa que no se ha cogido la llave y por 
	 tanto no se abrira*/
	public bool GetPocket(){
		return namePocket;
	}
}
