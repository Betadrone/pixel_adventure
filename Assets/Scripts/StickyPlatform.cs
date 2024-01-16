using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            coll.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            coll.gameObject.transform.SetParent(null);
        }
    }
}
