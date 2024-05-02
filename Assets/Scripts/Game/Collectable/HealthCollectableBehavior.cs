using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectableBehavior : Collectable, ICollectableBehavior
{

    public void OnCollected(GameObject player)
    {
        player.GetComponent<HealthController>().AddHealth(_healthAmount);
    }
}
