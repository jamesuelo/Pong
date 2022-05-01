using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float speed = 25;
    public string axis = "Vertical";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.sharedInstance.gameStarted)
        {
            float v = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * v);
    
        }
    }
}
