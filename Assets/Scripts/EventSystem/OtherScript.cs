using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScript : MonoBehaviour
{
    private GameObject thisObject;
    private float log;

    private void Awake()
    {
        thisObject = this.gameObject;
    }

    public void Flip()
    {
        thisObject.transform.Rotate(new Vector3(thisObject.transform.position.x, thisObject.transform.position.y, thisObject.transform.position.z - 45));
    }
}