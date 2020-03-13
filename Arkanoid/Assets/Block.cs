using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 1;
    Score scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<Score>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp--;
        if(hp <= 0)
        {
            scoreManager.addScore(hp);
            Destroy(gameObject);
        }
        
    }
}
