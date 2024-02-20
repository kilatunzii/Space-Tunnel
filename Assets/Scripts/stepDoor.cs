
using UnityEngine;
using UnityEngine.SceneManagement;


public class stepDoor : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "step") 
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
