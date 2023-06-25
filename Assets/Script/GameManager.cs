using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // 싱글톤 인스턴스

    private int score; // 현재 점수

    public TextMeshProUGUI scoreText; // Score 텍스트 객체

    private void Awake()
    {
        // 싱글톤 인스턴스 설정
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // 초기 점수 설정
        score = 0;
        UpdateScoreText();
    }

    // 점수 추가
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // Score 텍스트 업데이트
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}