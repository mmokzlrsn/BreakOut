using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    [SerializeField] private int _hp;

    public int HP { get => _hp; set => _hp = value; }

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

}
