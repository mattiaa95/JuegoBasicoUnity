using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJugador : MonoBehaviour {
    public float fuerza;
    public Text puntosUI;
    public Text finJuego;
    Rigidbody esfera;
    int puntos;

    private void Awake()
    {
        finJuego.enabled = false;
        esfera = GetComponent<Rigidbody>();
        puntos = 0;
        actualizarPuntos();
    }

    private void actualizarPuntos()
    {
        puntosUI.text = "Puntos: " + puntos;
    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal,0,movimientoVertical);
        esfera.AddForce(movimiento*fuerza);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        puntos++;
        actualizarPuntos();

        //Fin juego
        if (puntos == 11)
        {
            finJuego.enabled = true;
        }

    }
}
