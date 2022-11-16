using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _speed;
    [SerializeField] private List<Transform> _wayPoints;
    [SerializeField] private int k = 0;



    public void Setup(List<Transform> wayPoints)
    {
        _wayPoints = new List<Transform>();
        _wayPoints = wayPoints;
    }


    public void Damage(int damage)
    {
        _health -= damage;
        if (_health < 0)
            Death();
        
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (k < _wayPoints.Count)
        {
            transform.position = Vector3.MoveTowards(transform.position, _wayPoints[k].position, _speed * Time.deltaTime);
            if (transform.position == _wayPoints[k].position)
            {
                k++;
            }
        }
        else
        {
            k = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Weapon weap))
        {
            Debug.Log("Попал");
            Damage(weap.GetDamage());
            Destroy(weap.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.TryGetComponent(out Weapon weap))
        {
            Debug.Log("Попал");
            Damage(weap.GetDamage());
            Destroy(weap.gameObject);
        }
    }

    private void Death()
    {
        Debug.Log("Умираю");
        Destroy(gameObject);
    }

    
}
