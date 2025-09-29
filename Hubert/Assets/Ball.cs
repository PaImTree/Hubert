using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    public float startingspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5f;

        float xVelocity = -1f;
        
        if (isRight == true)
        {
            xVelocity = 1f;
        }


        float yVelocity = UnityEngine.Random.Range(-1, 1);
        
        rb.linearVelocity = new Vector2(xVelocity * startingspeed, yVelocity * startingspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
