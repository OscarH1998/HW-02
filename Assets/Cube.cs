using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }

    public void Duplicate()
    {
        GameObject newObject = Instantiate(cube, transform.position, Quaternion.identity);
    }

    public void MakeWall()
    {
        cube.transform.localScale = new Vector3(10f, 5f, 1f);
    }
}
