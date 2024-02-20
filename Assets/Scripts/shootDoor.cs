
using UnityEngine;
using UnityEngine.SceneManagement;

public class shootDoor : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "shoot") 
        {
            anim.SetBool("Near", true);
        }
        else
        {
            GoToGameOver();
        }
    }
    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
