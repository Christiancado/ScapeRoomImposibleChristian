using UnityEngine;
using System.Collections;

public class OpenSecretDoor : MonoBehaviour {

	[SerializeField]
	private GameObject objetoPuerta;
	private Animation abrirPuerta;

	void Start(){
		/*Se recoge el componente Animation que esta en el objeto
		 Puerta anidado en el GameObject llamado PuertaSecreta*/
		abrirPuerta = objetoPuerta.GetComponent<Animation>();
	}

	private void OnTriggerEnter(Collider collider){
		/*Ejecuta la animacion*/
		if(collider.name == "Player"){
			abrirPuerta.Play("openSecretDoor");
		}
	}

}
