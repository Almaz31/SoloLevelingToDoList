using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance { get; private set; }

    private string _nickname;
    private int _level;
    private int _exp;
    private int _countOfComplectedQuests;

    private void Awake()
    {
        if(Instance=null) Instance = this; 
    }

    public void SetNicname(string name)
    {
        _nickname = name;
    }
    public void IncreaseLevel(string name)
    {
        _level++;
    }
    public void IncreaseExp(int numOfExp)
    {
        _exp=+numOfExp;
    }
    public void QuestComplated()
    {
        _countOfComplectedQuests++;
    }
}
