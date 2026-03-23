using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    public override void Attack(Character enemyToHit)
    {
        float damage = activeWeapon.GetDamage();
        enemyToHit.TakeDamage(damage);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
