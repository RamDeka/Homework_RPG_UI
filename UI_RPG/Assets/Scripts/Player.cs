using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon[] weapons = new Weapon[3];
    
  
    private int activeWeaponIndex = 0;

    public override void Attack(Character enemyToHit)
    {
      
        float damage = weapons[activeWeaponIndex].GetDamage();
        enemyToHit.TakeDamage(damage);
    }

    void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.Alpha1)) activeWeaponIndex = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2)) activeWeaponIndex = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3)) activeWeaponIndex = 2;
    }
}