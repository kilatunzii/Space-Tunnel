


using UnityEngine;
using UnityEngine.SceneManagement;


public class lineDoor : MonoBehaviour
{
    public Animator anim;
   

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "line") 
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
