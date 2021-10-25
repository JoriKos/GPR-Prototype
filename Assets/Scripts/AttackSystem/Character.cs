using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private bool isAlive;
    private int attackCooldown;
    [SerializeField] private int health;
    [SerializeField] private int regularAttackDamage;
    [SerializeField] private int specialAttackDamage;
    [SerializeField] private GameObject[] enemies;

    private void Update()
    {
        if (health <= 0)
        {
            Kill();
        }
    }

    //Fill enemy array
    public GameObject[] FillEnemiesArray(string enemyType)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i] = GameObject.Find(enemyType + i);
        }
        return enemies;
    }

    //return array
    public GameObject[] GetArray()
    {
        return enemies;
    }


    public bool getStatus()
    {
        return isAlive;
    }

    private void Kill()
    {
        isAlive = false;
    }
}