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

    public float delaySpawn;
    public float gravityScale;

    private void Start()
    {
        //StartCoroutine(SpawnObject());
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

        Physics2D.gravity += new Vector2(0, gravityScale);
    }

    /*
    private IEnumerator SpawnObject()
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

        Physics2D.gravity += new Vector2(0, gravityScale);
        yield return new WaitForSeconds(1);
    }
    */

    public void SpawnAfterGameOver()
    {


    }

    private void Update()
    {
        if (_spawnedObject == null) Spawn();

        if (Input.GetKeyDown(KeyCode.S))
        {
            Spawn();
        };
    }


}
