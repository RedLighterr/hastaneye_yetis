using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time = 0;
    [SerializeField] TextMeshProUGUI time_text;

    void Update()
    {
        if (true)
        {
            time += Time.deltaTime;
            time_text.text = time.ToString("F0");
        }

    }
}
