using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class ChoosedWeapon : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Weapon _currentWeapon;
    [SerializeField] private Transform _positionSpawn;
    [SerializeField] private GameObject _ui;
    [SerializeField] private Image _image;
    private bool _flag = false;
    private int _counter = 0;



    private void Start()
    {
        _currentWeapon = _weapons[0];
        _image.sprite = _currentWeapon.GetSprite();

    }
    public void CreateWeapons()
    {
        var weapon = Instantiate(_currentWeapon, _positionSpawn.position, Quaternion.identity);
    }

    public void ActiveUi()
    {
        
        _flag = !_flag;
        _ui.SetActive(_flag);
    }

    public void NextWeapon()
    {
        _counter++;
        if (_counter >= _weapons.Count)
            _counter = 0;
        
        _currentWeapon = _weapons[_counter];
        _image.sprite = _currentWeapon.GetSprite();
    }

    public void NextWeapon(InputAction.CallbackContext value)
    {

        Vector2 vector = value.ReadValue<Vector2>();
        if (!(vector.x == 0 && vector.y == 0))
        {
            Debug.Log("X: " + vector.x + " Y: " + vector.y);
        }
    } 

    
}
