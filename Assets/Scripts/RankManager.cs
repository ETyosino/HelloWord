using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RankManager : MonoBehaviour
{
    [SerializeField]
    private List<PlayerDate> playerDates = new List<PlayerDate>();

    public List<Group> _group;
    private void Start()
    {
        foreach (Transform item in transform)
        {
            Debug.Log(item.name);
            _group.Add(item.GetComponent<Group>());
        }
        UIUpdate();
    }
    public void SortKillNumButton()
    {
        SortByBubble(getKillNum);
    }
    public void SortScoreButton()
    {
        SortByBubble(getScore);
    }
    
    
    
    private int getKillNum(PlayerDate _playerDate)
    {
        return _playerDate.PlayerKillNum;
    }
    
    private int getScore(PlayerDate _playerDate)
    {
        return _playerDate.PlayerHighestScore;
    }

    private delegate int MyDelegate(PlayerDate _playerDate);
    
    private void SortByBubble(MyDelegate _myDelegate)
    {
        for (int i = 0; i < playerDates.Count-1; i++)
        {
            for (int j = 0; j < playerDates.Count-i-1; j++)
            {
                if (_myDelegate(playerDates[j+1]) > _myDelegate(playerDates[j]))
                {
                    PlayerDate tmp = playerDates[j];
                    playerDates[j] = playerDates[j + 1];
                    playerDates[j + 1] = tmp;
                }
            }
        }
        UIUpdate();
    }
    private void UIUpdate()
    {
        for (int i = 0; i < playerDates.Count; i++)
        {
            _group[i].UpdateUI(playerDates[i]);
        }
    }
}
