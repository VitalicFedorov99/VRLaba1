using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemies : MonoBehaviour
{
    [SerializeField] private List<Enemy> _prefabsEnemy;
    [SerializeField] private List<Transform> _wayPoints;
    [SerializeField] private List<int> _waves;
    [SerializeField] private Transform _placeSpawn;
    [SerializeField] private float _cooldown;
    [SerializeField] private int k = 0;
    public IEnumerator SpawnEnemy()
    {
        Enemy enemy = Instantiate(_prefabsEnemy[0], _placeSpawn.position, Quaternion.identity);
        enemy.Setup(_wayPoints);
        yield return new WaitForSeconds(_cooldown);
        k++;
        if (k < _waves[0])
        {
            StartCoroutine(SpawnEnemy());
        }
    }


    public void CreateWave()
    {
            StartCoroutine(SpawnEnemy());   
    }

    private void Start()
    {
        CreateWave();
    }


}
