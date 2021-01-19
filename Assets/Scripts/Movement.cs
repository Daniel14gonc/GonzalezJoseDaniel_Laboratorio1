/*
 * Autor: Daniel Gonzalez Carrillo
 * Carne: 20293
 * Modificacion: 15/01/2021
 * 
 * Descripcion:
 *  Clase que permite mover un GameObject por medio de las flechas
 *  o WASD.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Modificacion de la posicion del GameObject por medio de las flechas o WASD.
        transform.Translate(Input.GetAxis("Horizontal") * velocity * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * velocity * Time.deltaTime);
    }
}
