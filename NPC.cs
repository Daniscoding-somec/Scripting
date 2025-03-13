using UnityEngine;

public class NPC : MonoBehaviour
{
    public int level;        // Nivel del NPC
    public int lives;        // Número de vidas del NPC
    public float speed;      // Velocidad del NPC

    void Start()
    {
        // Al comenzar el juego, actualizamos el número de vidas del NPC
        lives = level + lives;   // Sumamos el nivel a las vidas del NPC

        // Imprimimos el valor de las vidas para comprobar que se calculó correctamente
        Debug.Log("Número de vidas del NPC: " + lives);
    }

    void Update()
    {
        // Creamos la variable newPosition de tipo Vector3 para actualizar la posición
        Vector3 newPosition = transform.position;  // Obtenemos la posición actual del NPC

        // Actualizamos la posición en el eje Z para mover al NPC hacia adelante
        newPosition.z += speed * Time.deltaTime;    // sumamos el valor de la velocidad y el tiempo transcurrido

        // Asignamos la nueva posición al transform.position del NPC
        transform.position = newPosition;
    }
}

        // Asignamos la nueva posición al transform.position del NPC