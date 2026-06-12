using UnityEngine;
using System.Collections;

public class PoisonEnemy : Character
{
    [SerializeField] private float damagePerTick = 1f;
    [SerializeField] private int totalTicks = 3;
    [SerializeField] private float tickInterval = 1f;

    public override void Attack(Character toHit)
    {
        StartCoroutine(ApplyPoisonDamage(toHit));
    }

    private IEnumerator ApplyPoisonDamage(Character target)
    {
        for (int i = 0; i < totalTicks; i++)
        {
            if (target == null || target.health <= 0) yield break;

            yield return new WaitForSeconds(tickInterval);
            
            target.TakeDamage(damagePerTick);
        }
    }
}