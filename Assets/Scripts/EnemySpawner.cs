using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int spawnNumber;
    [SerializeField] private int spawnMinX,SpawnMaxX,spawnMinZ, SpawnMaxZ;
    private Vector3 _spawnPosition;
    private void Start() {

        for (int i = 0; i < spawnNumber; i++) {
            _spawnPosition = new Vector3(x: Random.Range(spawnMinX,SpawnMaxX), _spawnPosition.y, z: Random.Range(spawnMinZ, SpawnMaxZ));
            Instantiate(enemyPrefab, _spawnPosition, Quaternion.identity);
        }
    }
}
