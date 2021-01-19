/*
 * Autor: Daniel Gonzalez Carrillo
 * Carne: 20293
 * Modificacion: 15/01/2021
 * 
 * Descripcion:
 *  Clase que permite aumentar o disminuir el tamaño de un
 *  GameObject por medio de las teclas B(aumentar) y P(disminuir).
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
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
        //Condicionales para verificar si esta alguna tecla presionada para aumentar
        //el tamaño del objeto.
        if(Input.GetKey(KeyCode.B))
        {
            transform.localScale += new Vector3(velocity * Time.deltaTime, velocity * Time.deltaTime, velocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.P))
        {
            transform.localScale -= new Vector3(velocity * Time.deltaTime,
                velocity * Time.deltaTime, velocity * Time.deltaTime);
        }
    }
}
