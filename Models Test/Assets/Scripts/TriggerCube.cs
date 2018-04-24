using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour {

    private void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Cube Enter" + coll.gameObject.name);
    }

    private void OnTriggerExit(Collider coll)
    {
        Debug.Log("Cube Exit" + coll.gameObject.name);
    }

    private void OnTriggerStay(Collider coll)
    {
        Debug.Log("Cube Stay" + coll.gameObject.name);
    }
}
