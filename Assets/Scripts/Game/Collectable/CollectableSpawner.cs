using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : Collectable
{
    [SerializeField]
    private List<GameObject> _collectablePrefab;

    public void SpawnCollectable(Vector2 position)
    {
        int index = Random.Range(0, _collectablePrefab.Count);
        var selectedCollectable = _collectablePrefab[index];

        Instantiate(selectedCollectable, position, Quaternion.identity);
    }
}
