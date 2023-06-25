using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    public float fallHeight = -10f; // 플레이어가 낙하한 것으로 판단할 높이

    void Update()
    {
        if (transform.position.y <= fallHeight)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}