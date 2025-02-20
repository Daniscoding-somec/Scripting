using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;  // Speed of the fireball

    void Start()
    {
        // Destroy the fireball after 3 seconds
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        // Move the fireball forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the fireball hits an object tagged "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the enemy upon collision
            Destroy(collision.gameObject);
        }
    }
}