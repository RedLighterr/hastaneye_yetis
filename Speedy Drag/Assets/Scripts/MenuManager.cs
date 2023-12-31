using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] GameObject levelSelection;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject Buttons;

    public void BaslaGeriButton()
    {
        Buttons.SetActive(!Buttons.activeSelf);
        levelSelection.SetActive(!levelSelection.activeSelf);
    }

    public void CreditsGeriButton()
    {
        Buttons.SetActive(!Buttons.activeSelf);
        credits.SetActive(!credits.activeSelf);
    }

    public void NextButton(int levelId = 1)
    {
        SceneManager.LoadScene(levelId);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
