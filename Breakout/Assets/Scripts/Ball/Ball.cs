using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int _damage = 1;

    [SerializeField] ParticleSystem _glowParticleSystem;

    public int Damage { get => _damage; set => _damage = value; }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _glowParticleSystem.transform.position = collision.contacts[0].point;
        DoGlowing();
    }

    public void DoGlowing()
    {
        _glowParticleSystem.Play();
    }



}
