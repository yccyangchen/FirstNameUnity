using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalCoins.coinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber); //not always loading the scene
    }


}
