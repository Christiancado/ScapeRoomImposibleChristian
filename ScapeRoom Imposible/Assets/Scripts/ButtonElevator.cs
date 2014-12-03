using UnityEngine;
using System.Collections;

public class ButtonElevator : MonoBehaviour {

	[SerializeField]
	private GameObject button;
	private Animation pushButton;


	void Start(){
		/*Cojo el componente Animation que cuelga de Buttonp (el cual serializamos en
		 *button)*/
		pushButton = button.GetComponent<Animation>();
	}

	void OnTriggerEnter(Collider collider){
	
		/*Cuando entra Player en el Trigger asignado ejecuta la animacion del
		 boton (es presionarse y volver de forma mas lenta a su 
		 posicion original, las llamadas a lso metodos estan en 
		 la propia animacion*/
		if(collider.name == "Player"){
			pushButton.Play("buttonPress");
		}
	
	}

}
