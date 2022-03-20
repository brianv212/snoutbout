using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool cooldown = false;

    void Cooldown() {
        cooldown = false;
    }

    // Update is called once per frame
    void Update() {
        if ((Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.LeftControl)) && !cooldown) {
            Shoot();
            cooldown = true;
            Invoke("Cooldown", 0.25f);
        }
    }

    void Shoot () {
        // Shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}