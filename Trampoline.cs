using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Variable para almacenar el componente Jump del jugador
    private Jump playerJump;

    // Fuerza de salto alta y normal
    public float highJumpForce = 10f;
    public float normalJumpForce = 2f;

    // Este método se ejecuta cuando el jugador entra en el área de colisión
    private void OnTriggerEnter(Collider other)
    {
        // Encuentra el componente Jump del jugador y aumenta la fuerza de salto
        playerJump = other.GetComponent<Jump>();
        playerJump.jumpStrength = highJumpForce;
    }

    // Este método se ejecuta cuando el jugador sale del área de colisión
    private void OnTriggerExit(Collider other)
    {
        // Restaura la fuerza de salto normal
        playerJump.jumpStrength = normalJumpForce;
    }
}
