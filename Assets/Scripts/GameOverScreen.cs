

using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
#endif

#if UNITY_EDITOR
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
#endif
}
