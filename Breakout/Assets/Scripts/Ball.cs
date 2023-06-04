using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int _damage = 1;

    public int Damage { get => _damage; set => _damage = value; }
}
