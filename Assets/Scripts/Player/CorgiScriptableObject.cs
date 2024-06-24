using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "CorgiScriptableObject", menuName = "ScriptableObjects/Corgi", order = 1)]

public class CorgiScriptableObject : ScriptableObject
{
    public float speed;
    public float jumpForce;
}
