using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{

    public float MoveSpeed = 5f;
    public float ResetPosX = -10f;
    public float StartPosX = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

        if (transform.position.x < ResetPosX)
        {
            transform.position = new Vector2(StartPosX, transform.position.y);
        }
    }
}
