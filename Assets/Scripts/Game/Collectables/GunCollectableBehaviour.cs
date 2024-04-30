using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunCollectableBehaviour : MonoBehaviour, ICollectableBehavior
{
    [SerializeField]
    private float _originalshottime;

    [SerializeField]
    private float _gunspeed;

    [SerializeField]
    private float _cooldowntimer;

    private float _elapsedTime = 0f;
    //private int x = 2;
    private bool collected = false;
    private bool JustChanged = false;
    //private GameObject _player;

    public void OnCollected(GameObject player)
    {
        if (collected == false)
        {
            player.GetComponent<PlayerShoot>().IncreaseShotTime(_gunspeed);
            collected = true;
            JustChanged = true;
        }

        if (collected == true && JustChanged == false)
        {
            player.GetComponent<PlayerShoot>().IncreaseShotTime(_originalshottime);
            collected = false;
            return;
        }
        JustChanged = false;
        _elapsedTime = 0f;
    }

    //public void ResetTimeBetweenShots(GameObject player)
    // {
    //    player.GetComponent<PlayerShoot>().ResetShotTime(0.8f);
    // }

    private void Update()
    {
        if (collected == true)
        {
            _elapsedTime += Time.deltaTime;
            Debug.LogError(_elapsedTime);
            Debug.LogError("PlayerShoot component not found on player!");
            GameObject myGameObject = GameObject.Find("Player");
            if (_elapsedTime >= _cooldowntimer)
            {
                OnCollected(myGameObject);
            }
        }
    }
}




