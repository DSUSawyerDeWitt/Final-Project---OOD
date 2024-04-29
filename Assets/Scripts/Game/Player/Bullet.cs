using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float _DamageAmount;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        DestroyWhenOffScreen();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthController = collision.GetComponent<HealthController>();
            healthController.TakeDamamge(_DamageAmount);
            Destroy(gameObject);
        }
        if (collision.GetComponent<EnemySpawnerHealth>())
        {
            HealthController healthController = collision.GetComponent<HealthController>();
            healthController.TakeDamamge(_DamageAmount);
            Destroy(gameObject);
        }
    }

    private void DestroyWhenOffScreen()
    {
        Vector2 screenPosistion = _camera.WorldToScreenPoint(transform.position);

        if(screenPosistion.x < 0 || screenPosistion.x > _camera.pixelWidth ||
            screenPosistion.y < 0 || screenPosistion.y > _camera.pixelHeight)
        {
            Destroy(gameObject);
        }
    }
}
