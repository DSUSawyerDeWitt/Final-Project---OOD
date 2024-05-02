using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunCollectableBehaviour : Collectable, ICollectableBehavior
{
    [SerializeField]
    private float _gunspeed;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<PlayerShoot>().IncreaseShotTime(_gunspeed);
    }
}




