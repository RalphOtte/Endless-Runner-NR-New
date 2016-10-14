using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour{

    //General
    [SerializeField]private int _health;
    private string _healthString;
    [SerializeField]private Text playerHealthText;
    [SerializeField]private Text scoreText;

    public int Health
    {
        get { return _health; }

        set { _health = value; }
    }
    public int money;
	public float currentHeight;
    public float currentScore;
    private string currentScoreString;

    void Update()
    {
        UpdatePlayerHealthUI();
        UpdateScoreUI();
    }

    void UpdatePlayerHealthUI()
    {
       _healthString = _health.ToString();
        playerHealthText.text = "Health:" + _healthString; 
    }

    void UpdateScoreUI()
    {
        currentScoreString = currentScore.ToString();
        scoreText.text = "Score: " + currentScoreString;

    }
}
