using UnityEngine;
using UnityEditor.SceneManagement;  // Agregar esta librería para gestionar las escenas

public class SceneChange : MonoBehaviour
{
    // Campo público para almacenar el nombre de la escena a reiniciar
    public string sceneName;

    // Método para reiniciar la escena cuando el jugador entra en el área del disparador
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que entra es el jugador (suponemos que el jugador tiene la etiqueta "Player")
        if (other.CompareTag("Player"))
        {
            // Reiniciamos la escena usando EditorSceneManager
            EditorSceneManager.LoadScene(sceneName);
        }
    }
}