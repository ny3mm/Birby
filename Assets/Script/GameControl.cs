using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    Vector2 CheckpointPos;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        CheckpointPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    public void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }

    public void UpdateCheckpoint(Vector2 pos)
    {
        CheckpointPos = pos;
    }


    IEnumerator Respawn(float Duration)
    {
        
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(Duration);
        transform.position = CheckpointPos;
        spriteRenderer.enabled = true;
    }
    
  
}
