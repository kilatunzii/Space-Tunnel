
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = new Vector3(transform.position.x, transform.position.y, offset.z + player.position.z);
        transform.position = desiredPosition;
    }
}
