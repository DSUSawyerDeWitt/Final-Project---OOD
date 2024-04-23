using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private ICollectableBehavior _collectableBehavior;

    private void Awake()
    {
       _collectableBehavior = GetComponent<ICollectableBehavior>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null )
        {
            _collectableBehavior.OnCollected(player.gameObject);
            Destroy(gameObject);
        }
    }
}
