using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeloader : MonoBehaviour
{
    public LayerMask DeathLayer;

    void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(gameObject);
    }


}
