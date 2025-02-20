using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;

    // The location of the departure point of the fireball, accessible through the Inspector window.
    public Transform attackPoint;

    // Update is called once per frame.
    void Update()
    {
        // Check if the left mouse button is pressed.
        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate the fireball at the attack point's position and rotation.
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print ("Player health: " + health);

        {
        
        }
    }


}