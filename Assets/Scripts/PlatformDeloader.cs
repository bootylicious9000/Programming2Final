using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDeloader : MonoBehaviour
{

    public LayerMask DeathLayer;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if(((1 << collision.gameObject.layer) & DeathLayer) != 0)
        {
            Destroy(gameObject);
        }
    }
}
