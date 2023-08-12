using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;

    [Header("Attributes")]
    [SerializeField] public bool isStart = false;
    [SerializeField] public bool isLose = false;
    [SerializeField] public bool isWin = false;

    [Header("Time")]
    public float time = 0;
    [SerializeField] TextMeshProUGUI time_text;

    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);

        PlayerPrefs.GetInt("level", 1);

        time_text.text = time.ToString("F0");
    }

    void Update()
    {
        Timer();
        IsStart();
        IsLose();
    }

    void Timer()
    {
        if (isStart)
        {
            time -= Time.deltaTime;
            time_text.text = time.ToString("F0");
        }
    }

    void IsStart()
    {
        if (Input.anyKeyDown && !isStart && !isWin)
        {
            isStart = true;

            time_text.text = time.ToString("F0");
        }
    }

    public void IsWin()
    {
        if (!isLose)
        {
            isStart = false;
            isWin = true;
            winPanel.SetActive(true);

            time_text.text = time.ToString("F0");
            //PlayerPrefs.SetInt("level", (PlayerPrefs.GetInt("level", 1) + 1));
            //SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));
        }
    }

    void IsLose()
    {
        if (time <= 0)
        {
            isLose = true;
            isStart = false;
            time = 0;
            losePanel.SetActive(true);

            time_text.text = time.ToString("F0");
            //SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));
        }
    }

    public void NextButton(int levelId = 1)
    {
        SceneManager.LoadScene(levelId);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
}
