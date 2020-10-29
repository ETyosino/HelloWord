using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerDate",fileName = "PlayerDate")]
public class PlayerDate : ScriptableObject
{
    public string PlayerName;
    public Sprite PlayerSprite;

    public int PlayerHighestScore;
    public int PlayerKillNum;
}
