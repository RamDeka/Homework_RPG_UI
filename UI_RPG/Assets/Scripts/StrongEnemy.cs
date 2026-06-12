public class StrongEnemy : Enemy
{
    public override void Attack(Character toHit)
    {
        base.Attack(toHit);
        toHit.TakeDamage(10); 
    }
}