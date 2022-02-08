using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    [SerializeField] private List<Vector3> _spawnPoints;
    [SerializeField] private Fireball _fireballPrefab;

    private void Start()
    {
        StartCoroutine(SpawnFrieballs());  
    }

    private IEnumerator SpawnFrieballs()
    {
        while (true)
        {
            var waitForSeconds = new WaitForSeconds(2f);

            foreach (var point in _spawnPoints)
            {
                Instantiate(_fireballPrefab, point, Quaternion.identity);
            }

            yield return waitForSeconds;
        }
    }
}
