
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Vector3 direction;
    public float forwardSpeed;
    public float MoveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Move forward at a constant speed
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        

        //Move up and down depending on your input
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * MoveSpeed);

        //Move left and right depending on your input
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* MoveSpeed);

        //restricting the player to a certain area
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), Mathf.Clamp(transform.position.y, -1.5f, 1.5f), transform.position.z);

       
    }

}
