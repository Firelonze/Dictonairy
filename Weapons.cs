using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    int currentWeapon = 0;
    int shotgunAmmo = 5;
    int uziAmmo = 5;
    int rpgRockets = 5;

    Dictionary<string, int> ammunition = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        ammunition.Add("Shotgun", 5);
        ammunition.Add("Uzi", 5);
        ammunition.Add("RPG", 5);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Alpha1))
        switch (currentWeapon)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (shotgunAmmo > 0)
                    {
                        shotgunAmmo -= 1;
                        ammunition[WeaponTypes.Shotgun.ToString()] -= 1;
                        Debug.Log("Shoot Shotgun");
                    }
                    else
                    {
                        Debug.Log("Shotgun Empty");
                    }
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (uziAmmo > 0)
                    {
                        uziAmmo -= 1;
                        ammunition[WeaponTypes.Uzi.ToString()] -= 1;
                        Debug.Log("Shoot Uzi");
                    }
                    else
                    {
                        Debug.Log("Uzi Empty");
                    }
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (rpgRockets > 0)
                    {
                        rpgRockets -= 1;
                        ammunition[WeaponTypes.RPG.ToString()] -= 1;
                        Debug.Log("Shoot RPG");
                    }
                    else
                    {
                        Debug.Log("Shotgun Empty");
                    }
                }
                break;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
            Debug.Log(currentWeapon);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            currentWeapon = 1;
            Debug.Log(currentWeapon);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            currentWeapon = 2;
            Debug.Log(currentWeapon);
        }
    }
    private enum WeaponTypes
    {
        Shotgun = 5,
        Uzi = 15,
        RPG = 2
    }
}

