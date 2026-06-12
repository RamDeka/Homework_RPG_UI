using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;

    [SerializeField] private TMP_Text playerHPText;
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text enemyNameText;
    [SerializeField] private TMP_Text enemyHPText;

    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerNameText.text = player.CharacterName;
        enemyNameText.text = enemy.CharacterName;
        playerHPText.text = "HP: " + player.health.ToString("F1");
        enemyHPText.text = "HP: " + enemy.health.ToString("F1");
    }

    public void PlayerAttack()
    {
        if (player.health <= 0 || enemy.health <= 0) return;

        player.Attack(enemy);

        if (enemy.health > 0)
        {
            enemy.Attack(player);
        }

        UpdateUI();
    }
}