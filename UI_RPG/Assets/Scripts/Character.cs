using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [Header("Character Stats")]
    public float health = 5f;
    
    [SerializeField] 
    private string characterName;

    public string CharacterName
    {
        get { return characterName; }
    }

    public void TakeDamage(float damage)
    {
        if (health <= 0) return;

        health -= damage;
        Debug.Log(characterName + " took " + damage + " damage!");

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(characterName + " has died.");
    }

    public abstract void Attack(Character toHit);
}