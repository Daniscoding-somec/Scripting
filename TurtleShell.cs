using UnityEngine;

public class TurtleShell : MonoBehaviour
{
    // M�todo que se llama cuando otro objeto entra en el collider
    private void OnTriggerEnter(Collider other)
    {
        // Si la colisi�n es con la fireball
        if (other.CompareTag("Fireball"))
        {
            // Destruye al enemigo (TurtleShell)
            Destroy(gameObject);
            // Destruye la fireball
            Destroy(other.gameObject);
        }
    }
}