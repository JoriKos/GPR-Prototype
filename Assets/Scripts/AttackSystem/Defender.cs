using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private bool isAlive;

    private void Update()
    {
        if (health <= 0)
        {
            Kill(); 
        }
    }

    void Kill()
    {
        isAlive = false;
    }


    bool getStatus()
    {
        return isAlive;
    }
}
