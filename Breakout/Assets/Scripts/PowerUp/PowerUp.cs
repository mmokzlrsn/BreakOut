using UnityEngine.TextCore.Text;
using UnityEngine;
using System.Collections;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField] private float _value;
    [SerializeField] private float _duration;

    public float Value { get => _value; set => _value = value; }
    public float Duration { get => _duration; set => _duration = value; }

    public abstract IEnumerator ApplyPowerUp(GameObject gameObject);
}
