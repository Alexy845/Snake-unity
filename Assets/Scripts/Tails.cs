using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tails : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Transform> _snakeSpawn;
    public Transform snakePrefab;
    void Start()
    {
        _snakeSpawn = new List<Transform>();
        _snakeSpawn.Add(this.transform);
    }
    private void FixedUpdate()
    {
        for(int i = _snakeSpawn.Count - 1; i>0; i--)
        {
            _snakeSpawn[i].position = _snakeSpawn[i-1].position;
        }
    }
    private void grow()
    {
        Transform snakeSpawn = Instantiate(this.snakePrefab);
        snakeSpawn.position = _snakeSpawn[_snakeSpawn.Count - 1].position;

        _snakeSpawn.Add(snakeSpawn);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            grow();
        }
    }

}
