using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosedWeapon : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Weapon _currentWeapon;
    [SerializeField] private Transform _positionSpawn;
    private int _counter = 0;



    private void Start()
    {
        _currentWeapon = _weapons[0];
    }
    public void CreateWeapons()
    {
        var weapon = Instantiate(_currentWeapon, _positionSpawn.position, Quaternion.identity);
    }

   
    
}
