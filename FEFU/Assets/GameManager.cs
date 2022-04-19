using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    public GameObject tile;
    void Start()
    {

        InvokeRepeating("CreateObjects", 1, 1.85f);
        InvokeRepeating("CreateTile", 1, 2);

    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(12.35f, -0.7347001f, 0), Quaternion.identity);

    }
    
}