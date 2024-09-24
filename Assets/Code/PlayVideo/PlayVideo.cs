using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    // Variable para almacenar el Collider del botón
    private Collider2D botonCollider;
    [SerializeField] private VideoPlayer video;

    void Start()
    {
        botonCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        // Detectar si se hizo clic derecho (botón secundario del ratón)
        if (Input.GetMouseButtonDown(0))
        {
            // Convertir la posición del ratón a coordenadas de mundo
            Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Crear el raycast y verificar si choca con el collider del botón
            RaycastHit2D hit = Physics2D.Raycast(posicionMouse, Vector2.zero,100);

            // Comprobar si el raycast colisionó con algo y si fue con el botón
            if (hit.collider == botonCollider)
            {
                ActivarBoton();
            }
        }
    }

    // Función que se llama cuando se activa el botón
    void ActivarBoton()
    {
        Debug.Log("Botón activado con clic izquierdo");
    }
}