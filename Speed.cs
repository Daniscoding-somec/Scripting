using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Speed : MonoBehaviour
{
    public float speedFactor = 20f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    //Increasing the player's running speed
    
void OnTriggerExit(Collider other)
    {
        //Reducing the player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed = speedFactor;
    }
}
