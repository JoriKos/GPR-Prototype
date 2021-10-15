using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventScript : MonoBehaviour
{
    [Header("Unityevent")]
    public UnityEvent testEvent;

    private GameObject player;

    private void Start()
    {
        player = this.gameObject;
        testEvent.AddListener(Flip);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            testEvent.Invoke();
        }
    }

    void Flip()
    {
        player.transform.rotation = new Quaternion(player.transform.rotation.x, player.transform.rotation.y, player.transform.rotation.z + 180, );
    }
}
