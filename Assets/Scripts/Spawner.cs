using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnObjects;
    [SerializeField] private Vector2 _spawnDelay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }



    private IEnumerator Spawn()
    {
        while (true)
        {
            int carNumber = Random.Range(0, _spawnObjects.Length);
            GameObject car = Instantiate(_spawnObjects[carNumber], transform.position, Quaternion.Euler(0f,180f,0f));
            yield return new WaitForSeconds(Random.Range(_spawnDelay.x, _spawnDelay.y));
        }
    }


}
