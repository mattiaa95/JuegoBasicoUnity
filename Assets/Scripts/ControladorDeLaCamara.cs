using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour {

    public GameObject jugador;
    private Vector3 posicionRelativa;


	// Use this for initialization
	void Start () {
        posicionRelativa = transform.position - jugador.transform.position;


    }

    private void LateUpdate()
    {
        transform.position = jugador.transform.position + posicionRelativa;
    }
}
