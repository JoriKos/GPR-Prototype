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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisObject.transform.Rotate(new Vector3(thisObject.transform.position.x, thisObject.transform.position.y, thisObject.transform.position.z - 45));
        }
    }

    public void Flip()
    {
        log += 1;
        thisObject.transform.rotation = new Quaternion(1,1, thisObject.transform.rotation.z + 180, 1);
        Debug.Log(log);
    }
}