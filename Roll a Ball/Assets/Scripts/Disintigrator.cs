using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disintigrator : MonoBehaviour {

    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "Coin")
        {
            Destroy(node.gameObject);
        }
    }

}
