using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Header("Unityevent")]
    public UnityEvent Attack;

    [SerializeField] private Character character;

    private void Awake()
    {
        character = this.gameObject.GetComponent<Character>();
        character.FillEnemiesArray("Defender");
    }

    private void Update()
    {
        
    }
}
