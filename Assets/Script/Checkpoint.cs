using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    GameControl gameController;

    SpriteRenderer sprtiteRenderer;
    public Sprite passive, active;

    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<GameControl>();
        sprtiteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.UpdateCheckpoint(transform.position);
            sprtiteRenderer.sprite = active;
        }
    }
}
