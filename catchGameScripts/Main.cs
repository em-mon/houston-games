using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public int score;
    public bool GameOver;
    public Transform title;
    public TextMeshProUGUI scoreboard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        GameOver = false;
        scoreboard.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true)
        {
            title.localPosition = new Vector3(0f, 0f, 0f);
            GameOver = false;
        }
    }

    public void ScoreAdd()
    {
        score++;
        scoreboard.text = score.ToString();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
