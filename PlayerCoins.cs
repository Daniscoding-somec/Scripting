using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coinCount = 0;

    // M�todo para a�adir una moneda al contador
    public void AddCoin()
    {
        coinCount++;
        // Actualiza la interfaz de usuario o cualquier otra l�gica adicional
        Debug.Log("Monedas: " + coinCount);
    }
}
