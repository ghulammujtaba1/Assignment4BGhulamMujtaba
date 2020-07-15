using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    public void onclickpenguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void onclickhummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
}

