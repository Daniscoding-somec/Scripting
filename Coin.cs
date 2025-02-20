using UnityEngine;

public class Coin : MonoBehaviour
{
    // Define el m�todo que se ejecuta al entrar en contacto con el jugador
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama al m�todo que actualiza el n�mero de monedas y destruye la moneda
            CollectCoin(other);
        }
    }

    // M�todo para manejar la recogida de la moneda
    void CollectCoin(Collider player)
    {
        // Obt�n el componente del jugador que maneja las monedas
        PlayerCoins playerCoins = player.GetComponent<PlayerCoins>();

        // Aumenta el n�mero de monedas del jugador
        if (playerCoins != null)
        {
            playerCoins.AddCoin();
        }

        // Destruye la moneda
        Destroy(gameObject);
    }
}
