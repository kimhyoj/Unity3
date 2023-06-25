using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public int scoreValue = 1; // 아이템이 주는 점수 값

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어와 충돌했을 때 아이템을 비활성화
            gameObject.SetActive(false);

            // Score 증가
            GameManager.Instance.AddScore(scoreValue);
        }
    }
}

