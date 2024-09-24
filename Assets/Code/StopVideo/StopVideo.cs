using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Puntero : MonoBehaviour
{
    // Variable para almacenar el Collider del botón
    private Collider2D botonCollider;
    [SerializeField] private VideoPlayer pantallaVideo;

    void Start()
    {
        botonCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        // Detectar si se hizo clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            // Convertir la posición del ratón a coordenadas
            Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Verificar si choca con el collider del botón con un raycast
            RaycastHit2D hit = Physics2D.Raycast(posicionMouse, Vector2.zero,100);

            // Comprobar si el raycast colisiona con el botón
            if (hit.collider == botonCollider)
            {
                ActivarBoton();
            }
        }
    }

    // Función que se llama cuando se activa el botón
    void ActivarBoton()
    {
        pantallaVideo.Stop();
    }
}