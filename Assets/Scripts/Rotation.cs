/*
 * Autor: Daniel Gonzalez Carrillo
 * Carne: 20293
 * Modificacion: 15/01/2021
 * 
 * Descripcion:
 *  Clase que permite crear una rotacion para un GameObject
 *  que tiene otros GameObject relativos a el.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    float velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotacion del objeto que modifica la posicion luego de cada frame.
        transform.Rotate(0, Time.deltaTime * velocity, 0);
    }
}
