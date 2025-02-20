using UnityEngine;

public class Coin : MonoBehaviour
{
    // Define el método que se ejecuta al entrar en contacto con el jugador
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama al método que actualiza el número de monedas y destruye la moneda
            CollectCoin(other);
        }
    }

    // Método para manejar la recogida de la moneda
    void CollectCoin(Collider player)
    {
        // Obtén el componente del jugador que maneja las monedas
        PlayerCoins playerCoins = player.GetComponent<PlayerCoins>();

        // Aumenta el número de monedas del jugador
        if (playerCoins != null)
        {
            playerCoins.AddCoin();
        }

        // Destruye la moneda
        Destroy(gameObject);
    }
}
