using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryAgainButton : MonoBehaviour
{
    public void tryAgain()
    {
        SceneManager.LoadScene(0);
        life.lifes = 3;
        diamond.point = 0;
        wrongbutton.chance = 0;
    }
}

