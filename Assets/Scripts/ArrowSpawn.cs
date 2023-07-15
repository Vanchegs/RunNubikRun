using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    public void SetDIrection(Vector2 dir)
    {

    }

    class ArrowSpawner
    {
        [SerializeField] private Vector2 arrowsDirection;
        [SerializeField] private float arrowDirection;
        [SerializeField] private ArrowSpawn arrowPrefab;
    }
}
