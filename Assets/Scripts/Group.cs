using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Group : MonoBehaviour
{
    public Image PlayerSprite;
    public Text PlayerName;
    public Text KillNum;
    public Text HighestScore;

    public void UpdateUI(PlayerDate _player)
    {
        PlayerSprite.sprite = _player.PlayerSprite;
        PlayerName.text = _player.PlayerName;
        KillNum.text = _player.PlayerKillNum.ToString();
        HighestScore.text = _player.PlayerHighestScore.ToString();
        Debug.Log(111);
    }

    public void MouseEnter()
    {
        LeanTween.scale(gameObject, 
            new Vector3(1.2f, 1.2f, 1.2f), 0.5f).setEaseShake();
    }
    
    public void MouseExit()
    {
        LeanTween.scale(gameObject, 
            new Vector3(1f, 1f, 1f), 0.5f);
    }
}
