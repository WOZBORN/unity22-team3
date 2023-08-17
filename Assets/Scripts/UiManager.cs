using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public void ItchIoClick()
    {
        Application.OpenURL("https://sanilam.itch.io");
    }
    public void PlayClick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitClick()
    {
        Application.Quit();
    }
    public void MenuClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
