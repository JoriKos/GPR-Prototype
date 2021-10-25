using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private Character character;

    private void Awake()
    {
        character = this.gameObject.GetComponent<Character>();
        character.FillEnemiesArray("Attacker");
    }
}
