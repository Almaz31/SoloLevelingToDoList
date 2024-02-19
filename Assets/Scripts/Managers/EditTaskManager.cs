using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditTaskManager : MonoBehaviour
{
    [SerializeField] private GameObject EditTaskTemplate;


    private List<TaskItem> TaskItems;
    private void Awake()
    {
        TaskItem _pushUpItem = new TaskItem("Push Ups", 100);
        TaskItem _squadsItem = new TaskItem("Squads", 100);
        TaskItem _crunchesItem = new TaskItem("Сrunches", 100);
        TaskItem _runningItem = new TaskItem("Running", 10);
        TaskItems.Add(_pushUpItem);
        TaskItems.Add(_squadsItem);
        TaskItems.Add(_crunchesItem);
        TaskItems.Add(_runningItem);
    }
    private void Start()
    {

    }
    private void UpdateItems()
    {
        
    }
}
