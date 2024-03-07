using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class EditTaskManager : MonoBehaviour
{
    [SerializeField] private GameObject EditTaskTemplate;
    [SerializeField] private GameObject Context;

    private List<TaskItem> TaskItems;

    private void Awake()
    {

        TaskItems = InitialiseTaskList();
        
        UpdateItems();
    }
    private void UpdateItems()
    {
        foreach (var item in TaskItems)
        {
            GameObject newTaskBlock = Instantiate(EditTaskTemplate, Context.transform);

            // Отримати посилання на поля Name та Count у новому блоку
            TextMeshProUGUI nameText = newTaskBlock.transform.Find("Name").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI countText = newTaskBlock.transform.Find("Count").GetComponent<TextMeshProUGUI>();

            // Налаштувати значення полів у новому блоку зі значеннями з елементу TaskItem
            nameText.text = item.taskName;
            countText.text = item.repeatCount.ToString();
        }
    }
    private List<TaskItem> InitialiseTaskList() { 
        List<TaskItem> startList = new List<TaskItem>();
        TaskItem _pushUpItem = new TaskItem("Push Ups", 100,1);
        TaskItem _squadsItem = new TaskItem("Squads", 100,1);
        TaskItem _crunchesItem = new TaskItem("Сrunches", 100,1);
        TaskItem _runningItem = new TaskItem("Running", 10, 1);


        startList.Add(_pushUpItem);
        startList.Add(_squadsItem);
        startList.Add(_crunchesItem);
        startList.Add(_runningItem);
        return startList;
    }

  
}
