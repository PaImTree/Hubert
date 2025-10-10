using UnityEngine;
using System.Collections; // Needed for IEnumerator (coroutines)

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed = 5f;
    public float resetDelay = 1.5f; // Wait time before relaunch

    void Start()
    {
        LaunchBall();
    }

    void LaunchBall()
    {
        float xDirection = UnityEngine.Random.value < 0.5f ? -1f : 1f;
        float yDirection = UnityEngine.Random.Range(-0.8f, 0.8f);

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;
        rb.linearVelocity = direction * startingSpeed;
    }

    public void ResetBall()
    {
        // Stop movement and center the ball
        rb.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;

        // Relaunch after a short delay
        StartCoroutine(LaunchAfterDelay());
    }

    private IEnumerator LaunchAfterDelay()
    {
        yield return new WaitForSeconds(resetDelay);
        LaunchBall();
    }

    // Detect if ball hits a goal zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            ResetBall();
        }
    }
}