using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {
        playerPosition = player.position;
    }   

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (Vector3.Distance(transform.position, playerPosition) < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
