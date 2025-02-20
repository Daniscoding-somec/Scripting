using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10f; // Velocidad de la fireball

    void Update()
    {
        // Mueve la fireball hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}