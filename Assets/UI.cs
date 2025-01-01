using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI ammoText;

    private int scoreValue;

    private void Awake() 
    {
        instance = this;    
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time >= 1)
            timerText.text = Time.time.ToString("#,#");
    }

    public void AddScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString("#,#");
    }
}
