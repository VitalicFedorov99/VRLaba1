using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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

    public void NextWeapon(InputAction.CallbackContext value)
    {

        Vector2 vector = value.ReadValue<Vector2>();
        if (!(vector.x == 0 && vector.y == 0))
        {
            Debug.Log("X: " + vector.x + " Y: " + vector.y);
        }
        /*if (_counter >= _weapons.Count)
        {
            _counter = 0;
        }
        if(_counter < 0)
        {
            _counter = _weapons.Count - 1;
        }*/
    } 

    
}
