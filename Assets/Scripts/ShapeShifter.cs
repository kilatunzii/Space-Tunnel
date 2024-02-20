
using UnityEngine;

public class ShapeShifter : MonoBehaviour
{
    //Create an array of gameobjects for shapes
    public GameObject[] shapes;
    public int currentShapeIndex;

    // Start is called before the first frame update
    void Start()
    {
        //initialising the start shape
        currentShapeIndex = 0;
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].SetActive(false);
            if (i == currentShapeIndex )
                shapes[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shapeShift();
        }
    }

    public void shapeShift()
    {
        shapes[currentShapeIndex].SetActive(false) ;

        //Increment shape index
        currentShapeIndex++;
        if (currentShapeIndex >= shapes.Length)
        {
            currentShapeIndex = 0;
        }
        shapes[currentShapeIndex].SetActive(true) ;
    }
}
