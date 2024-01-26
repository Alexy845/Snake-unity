using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFood : MonoBehaviour
{
    public GameObject food;
    public float spawnRadius = 15f;    

    // Start is called before the first frame update
    void Start()
    {

        Invoke("Spawn", 0f);
    }

    public void Comit()
    {
        Invoke("Spawn", 0f);

    }

    void Spawn()
    {
        Vector2 randomPos = (Vector2)transform.position + Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(food, randomPos, Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        // Peut-être ajouter du code ici si nécessaire
    }
}
