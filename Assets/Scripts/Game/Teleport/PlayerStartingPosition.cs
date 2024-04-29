using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartingPosition : MonoBehaviour
{
    public GameObject Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Player.transform.position = new Vector2(45, 45);
    }
}
