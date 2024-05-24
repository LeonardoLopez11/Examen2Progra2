using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamejolt : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool success) =>
        {
            if (success)
            {
                
                UnlockTrophy();
                SceneManager.LoadScene("Level");
            }
            else
            {
                
            }
        });

    }

    // Update is called once per frame
    void Update()
    {

    }

    void UnlockTrophy()
    {
        Trophies.Unlock(233910);
    }

}
