using UnityEngine;
using System.Collections.Generic;

public class GenericsGame : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        GameObject enemy1 = new GameObject("Creeper");
        GameObject enemy2 = new GameObject("Skeleton");

        enemies.Add(enemy1);
        enemies.Add(enemy2);

        Debug.Log("Enemy count: " + enemies.Count);
    }
}

