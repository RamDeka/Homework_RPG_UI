using UnityEngine;

public class ScalingBlade : Blade
{
    [SerializeField] private float multiplierPerHit = 0.1f; 
    private int hitCount = 0;

    public override float GetDamage()
    {
       
        float baseDamage = base.GetDamage();
        
        float totalDamage = baseDamage + (baseDamage * (multiplierPerHit * hitCount));
        
       
        hitCount++;
        
        return totalDamage;
    }
    
    public void ResetCombo()
    {
        hitCount = 0;
    }
}