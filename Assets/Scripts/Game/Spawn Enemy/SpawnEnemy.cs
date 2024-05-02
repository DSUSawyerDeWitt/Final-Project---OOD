using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    protected float _timeUntilSpawn;

    protected virtual void SpawnFaster()
    {
        _timeUntilSpawn = 2;
    }
}
