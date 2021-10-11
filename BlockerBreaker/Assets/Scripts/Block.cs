using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] hitSprites;

    Level level;

    [SerializeField] int timesHit;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            DestroyBlock(collision);
        }
        else
        {
            ShowNextHitSprite();
        }
    }

    private void ShowNextHitSprite()
    {
        int spriteIndex = timesHit - 1;
        if(hitSprites[spriteIndex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("BlockSprite is Missing lmao");
        }
    }

    private void DestroyBlock(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        Debug.Log(collision.gameObject.name);
        level.BlockDestroyed();
        FindObjectOfType<GameStatus>().AddToScore();
    }
}
