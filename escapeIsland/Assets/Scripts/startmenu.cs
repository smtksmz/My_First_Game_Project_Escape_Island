using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    private Scene startchap;
    private void Start()
    {
        startchap = SceneManager.GetActiveScene();
    }
    public void chapterstart()
    {
        SceneManager.LoadScene(startchap.buildIndex + 1);
    }
}
