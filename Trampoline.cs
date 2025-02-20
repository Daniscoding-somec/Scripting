using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Variable para almacenar el componente Jump del jugador
    private Jump playerJump;

    // Fuerza de salto alta y normal
    public float highJumpForce = 10f;
    public float normalJumpForce = 2f;

    // Este m�todo se ejecuta cuando el jugador entra en el �rea de colisi�n
    private void OnTriggerEnter(Collider other)
    {
        // Encuentra el componente Jump del jugador y aumenta la fuerza de salto
        playerJump = other.GetComponent<Jump>();
        playerJump.jumpStrength = highJumpForce;
    }

    // Este m�todo se ejecuta cuando el jugador sale del �rea de colisi�n
    private void OnTriggerExit(Collider other)
    {
        // Restaura la fuerza de salto normal
        playerJump.jumpStrength = normalJumpForce;
    }
}
