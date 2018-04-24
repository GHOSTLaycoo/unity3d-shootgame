using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCube : MonoBehaviour {

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name != "Ground")
            Debug.Log("Enter" + coll.gameObject.name);
    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.name != "Ground")
            Debug.Log("Exit" + coll.gameObject.name);
    }

    private void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.name != "Ground")
            Debug.Log("Stay" + coll.gameObject.name);
    }
}
