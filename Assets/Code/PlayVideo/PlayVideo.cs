using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    // Variable para almacenar el Collider del botón
    private Collider2D botonCollider;
    private string[] videos;
    [SerializeField] private VideoPlayer pantallaVideo;

    void Start()
    {
        botonCollider = GetComponent<Collider2D>();

        // Obtener todos los archivos .mp4 de la carpeta viode
        videos = Directory.GetFiles("Assets/Video", "*.mp4").Select(Path.GetFullPath).ToArray();
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
    private void ActivarBoton()
    {
        VideoRandom();
    }

    // Función para reproducir un video aleatorio
    private void VideoRandom()
    {
        if (videos.Length == 0)
        {
            Debug.LogError("No se encontraron videos en la carpeta");
            return;
        }

        // Seleccionar un video aleatorio
        string randomVideo = videos[Random.Range(0, videos.Length)];

        // Cargar el video en el VideoPlayer
        pantallaVideo.url = randomVideo;
        pantallaVideo.Play();
    }
}