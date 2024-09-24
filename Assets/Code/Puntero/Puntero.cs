using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntero : MonoBehaviour
{
    // Variable para almacenar el Collider del botón
    private Collider2D botonCollider;

    void Start()
    {
    
    }

    void Update()
    {
        // Detectar si se hizo clic derecho (botón secundario del ratón)
        if (Input.GetMouseButtonDown(1))
        {
            // Convertir la posición del ratón a coordenadas de mundo
            Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Crear el raycast y verificar si choca con el collider del botón
            RaycastHit2D hit = Physics2D.Raycast(posicionMouse, Vector2.zero);

            // Comprobar si el raycast colisionó con algo y si fue con el botón
            if (hit.collider != null && hit.collider == botonCollider)
            {
                ActivarBoton();
            }
        }
    }

    // Función que se llama cuando se activa el botón
    void ActivarBoton()
    {
        Debug.Log("Botón activado con clic derecho");
    }
}
