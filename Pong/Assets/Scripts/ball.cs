using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 25;
    public bool hasTheballMoved = false;
    // Start is called before the first frame update
    void Start()
    {
    }


    private void Update()
    {
        if (GameManager.sharedInstance.gameStarted && !hasTheballMoved)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            hasTheballMoved = true;
        }
         
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pad Left")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }

        if (collision.gameObject.name == "Pad Right")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }

    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float raquetHeight)
    {
        return (ballPosition.y - racketPosition.y) / raquetHeight;
    }
}
