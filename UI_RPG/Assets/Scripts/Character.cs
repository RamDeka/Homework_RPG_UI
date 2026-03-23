using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health = 5f;
    [SerializeField]
    private string name;

    public string Namec
    {
        get { return name; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        Debug.Log(name + " took " + damage);
    }

    //public void TakeDamage(Weapon thrownWeapon)
  //  {
       // float damage = thrownWeapon.Getdamage();
      // TakeDamage(damage);
        
   // }

    public abstract void Attack(Character toHit);
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
