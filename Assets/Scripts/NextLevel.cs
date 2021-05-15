using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int whichScene;

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name == "Player" && whichScene == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        whichScene = SceneManager.GetActiveScene().buildIndex;
    }
}
