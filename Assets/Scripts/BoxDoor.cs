
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxDoor : MonoBehaviour
{
    public Animator anim;
    

 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "box") 
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
