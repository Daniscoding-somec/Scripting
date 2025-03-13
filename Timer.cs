using UnityEngine;
using UnityEngine.SceneManagement; // Required for restarting the level

public class Timer : MonoBehaviour
{
    public int minutes = 1; // Set the initial minutes
    public float seconds = 0f; // Seconds will be updated each frame

    void Update()
    {
        // Reduce seconds by deltaTime
        seconds -= Time.deltaTime;

        // Check if seconds are finished
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                // Subtract a minute and reset seconds to 59
                minutes--;
                seconds = 59f;
            }
            else
            {
                // Restart the level when time runs out
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
