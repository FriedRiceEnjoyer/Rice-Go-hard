using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawningRange;
    float timer = 0f;

    private Vector3 RandomSpawningPosition()
    {
        float xPos = Random.Range(transform.position.x - SpawningRange, transform.position.x + SpawningRange);
        float yPos = Random.Range(transform.position.y - SpawningRange, transform.position.y + SpawningRange);

        Vector3 spawningPos = new Vector3(xPos, yPos);

        return spawningPos;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 3f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            Instantiate(EnemyPrefab, RandomSpawningPosition(), transform.rotation);
        }
    }
}