using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;

    [SerializeField] private float fireRate = 0.25f;

    private float nextFireTime;

    private void Update()
    {
        HandleShooting();
    }

    private void HandleShooting()
    {
        if (CanShoot())
        {
            Shoot();
        }
    }

    private bool CanShoot()
    {
        return Input.GetKey(KeyCode.Space) &&
               Time.time >= nextFireTime;
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        AudioManager.Instance.PlayShootSound();
        nextFireTime = Time.time + fireRate;
    }
}