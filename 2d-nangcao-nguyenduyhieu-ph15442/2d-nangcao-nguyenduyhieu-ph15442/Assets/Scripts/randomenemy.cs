using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomenemy : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            SpawRandom(new Vector2(Random.Range(-1f, 1f), Random.Range(-8f, 8f)));
        }
    }

    // Update is called once per frame
    void SpawRandom(Vector2 position)
    {
        GameObject perfab = enemy[Random.Range(0, enemy.Length)];
        Instantiate(perfab, position, Quaternion.identity, transform);
        Debug.Log(perfab.name);
    }
}
