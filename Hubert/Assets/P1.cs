using UnityEngine;
using UnityEngine.Windows;

public class P1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.Getkey(KeyCode.W);
        bool isPressingDown = Input.Getkey(KeyCode.S);

        if (isPressingUp)
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }
        
        if (isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
    }
}
