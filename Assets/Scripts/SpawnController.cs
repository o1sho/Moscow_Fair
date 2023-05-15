using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;

    //////
    [System.Serializable]
    public struct SpawnableObject
    {
        public GameObject platformPrefabs;
        [Range(0f, 1f)]
        public float spawnChance;
    }
    public SpawnableObject[] objects;
    //////

    private GameObject _spawnedObject;


    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    public void Spawn()
    {
        Transform randomPointSpawn = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

        ///////////
        float spawnChance = Random.value;
        foreach (var obj in objects)
        {
            if (spawnChance < obj.spawnChance)
            {
                _spawnedObject = Instantiate(obj.platformPrefabs, randomPointSpawn.position, Quaternion.identity);
                break;
            }

            spawnChance -= obj.spawnChance;
        }
        ///////////

        //GameObject randomPlatformPrefab = _platformPrefabs[Random.Range(0, _platformPrefabs.Length)];
        //Instantiate(randomPlatformPrefab, randomPointSpawn.position, Quaternion.identity);

    }

    public void SpawnAfterGameOver()
    {


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Spawn();
        };
    }
}
