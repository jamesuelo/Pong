using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public static GameManager sharedInstance = null;
    public bool gameStarted = false;

    public Text title;
    public Button start;
    Vector2 nextDirection;
    private void Awake()
    {
        if (sharedInstance == null)
            sharedInstance = this;
    }

    // Start is called before the first frame update
    public void StartGame()
    {
        gameStarted = true;
        title.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    GameObject ball;
    public void GoalScored()
    {
        ball.transform.position = Vector2.zero;
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero ;
        nextDirection = new Vector2(-ball.GetComponent<Rigidbody2D>().velocity.x, 0);
        Invoke("LaunchBall", 2.0f);
    }
    void LaunchBall()
    {
        ball b = ball.GetComponent<ball>();
        ball.GetComponent<Rigidbody2D>().velocity = nextDirection.normalized * b.speed;
    }
}
