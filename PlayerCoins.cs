using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coinCount = 0;

    // Método para añadir una moneda al contador
    public void AddCoin()
    {
        coinCount++;
        // Actualiza la interfaz de usuario o cualquier otra lógica adicional
        Debug.Log("Monedas: " + coinCount);
    }
}
