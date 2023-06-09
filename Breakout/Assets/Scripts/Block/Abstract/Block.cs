using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private ParticleSystem _particleSystem;

    public int HP { get => _hp; set => _hp = value; }
    public AudioClip AudioClip { get => _audioClip; set => _audioClip = value; }
    public ParticleSystem ParticleSystem { get => _particleSystem; set => _particleSystem = value; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(Tags.BallTag))
        {
            TakeDamage(collision.gameObject.GetComponent<Ball>().Damage);
        }
    }

    public virtual void TakeDamage(int damage)
    {
        _hp -= damage;
        CheckForDestroy();
    }

    public void CheckForDestroy()
    {
        if(_hp <= 0)
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if(_audioClip != null) AudioManager.instance.PlaySFX(_audioClip);
        if(_particleSystem != null) _particleSystem.Play();
    }



}
