using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadTerrain()
    {
        SceneManager.LoadScene("01-TerrainExperiment");

    }
    public void LoadSnaps()
    {
        SceneManager.LoadScene("02-Interiors");

    }
}
