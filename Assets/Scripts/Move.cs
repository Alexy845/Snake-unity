using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    enum Direction { Up, Right, Down, Left};

    Direction direction = Direction.Up;

    [SerializeField] float distance;
    [SerializeField] float sequence;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Moving", 0.5f, sequence);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            if(direction != Direction.Down)
            {
                direction = Direction.Up;
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            if (direction != Direction.Up)
            {
                direction = Direction.Down;
            }
        }
        else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (direction != Direction.Right)
            {
                direction = Direction.Left;
            }

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (direction != Direction.Left)
            {
                direction = Direction.Right;
            }
        }
    }
    void Moving()
    {
        switch(direction)
        {
            case Direction.Up:
                transform.Translate(Vector2.up * distance);
                break;
            case Direction.Left:
                transform.Translate(Vector2.left * distance);
                break;
            case Direction.Right:
                transform.Translate(Vector2.right * distance);
                break;
            case Direction.Down:
                transform.Translate(Vector2.down * distance);
                break;
        }
    }

    public void Stop()
    {
        CancelInvoke("Moviendo");
    }
}
