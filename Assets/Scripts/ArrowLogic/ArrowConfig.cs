using UnityEngine;

[System.Serializable]
public class ArrowConfig
{
    [field: SerializeField] public Vector2 ArrowsDirection { get; private set; }
    [field: SerializeField] public float ArrowsSpeed { get; private set; }
}
