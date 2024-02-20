
using UnityEngine;
using UnityEngine.SceneManagement;



#if UNITY_EDITOR
public class MainMenu : MonoBehaviour
{
 public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");

    }
#endif

#if UNITY_EDITOR
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
#endif
}
