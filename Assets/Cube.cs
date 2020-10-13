using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject objectToSpawn;

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

    public void SpawnCube()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
