using UnityEngine;
using UnityEditor.SceneManagement;  // Agregar esta librer�a para gestionar las escenas

public class SceneChange : MonoBehaviour
{
    // Campo p�blico para almacenar el nombre de la escena a reiniciar
    public string sceneName;

    // M�todo para reiniciar la escena cuando el jugador entra en el �rea del disparador
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