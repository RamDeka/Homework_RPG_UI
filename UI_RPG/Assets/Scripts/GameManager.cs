using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;

    [SerializeField] private TMP_Text playerHPText, playerNameText, enemyNametext, enemyHPText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       UpdateUI();
    }
    

    private void UpdateUI()
    {
        playerNameText.text = player.name;
        enemyNametext.text = enemy.name;
        playerHPText.text = "HP: " + player.health.ToString("F1");
        enemyHPText.text = "HP: " + enemy.health.ToString("F1");
    }
    
    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }
    

    // Update is called once per frame
    
    
}
