using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCuboOro : MonoBehaviour {

    Vector3 rotacion = new Vector3(5,25,5);

	// Update is called once per frame
	void Update () {
        transform.Rotate(rotacion*Time.deltaTime);

    }


}
