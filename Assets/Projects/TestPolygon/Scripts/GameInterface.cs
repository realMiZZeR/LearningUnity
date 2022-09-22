using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterface : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Text _bulletAmountTextElement;

    private void Update()
    {
        if(_player._currentWeaponData != null)
        {
            _bulletAmountTextElement.text = _player._currentWeaponData.bulletAmount.ToString();
        }
        
    }
}
