using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitClick()
    {
        Application.Quit();
    }
    public void MenuClick()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
