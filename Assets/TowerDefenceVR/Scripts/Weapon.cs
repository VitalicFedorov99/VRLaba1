using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private Sprite _sprite;

    public int GetDamage()
    {
        return _damage;
    }
    
    public Sprite GetSprite()
    {
        return _sprite;
    }

    //public Sprite
}
