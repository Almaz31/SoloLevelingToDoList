using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct TaskContainer
{
    public List<TaskItem> items;
}
public class EditTaskManager : MonoBehaviour
{
    [SerializeField] private GameObject EditTaskTemplate;

    private TaskDataManager dataManager;
    private List<TaskItem> TaskItems;
    private TaskContainer container;
    private void Awake()
    {
        container = new TaskContainer();
        dataManager = new TaskDataManager();
        TaskItems = new List<TaskItem>();
        TaskItem _pushUpItem = new TaskItem("Push Ups", 100);
        TaskItem _squadsItem = new TaskItem("Squads", 100);
        TaskItem _crunchesItem = new TaskItem("Сrunches", 100);
        TaskItem _runningItem = new TaskItem("Running", 10);
        TaskItems.Add(_pushUpItem);
        TaskItems.Add(_squadsItem);
        TaskItems.Add(_crunchesItem);
        TaskItems.Add(_runningItem);
        SaveTasks();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadTasks();
            Debug.Log("R pressed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveTasks();
            Debug.Log(container.items);
        }
    }
    private void UpdateItems()
    {
        
    }
    public void SaveTasks()
    {
        container.items = TaskItems;
        foreach(TaskItem item in container.items) {
            Debug.Log(item);
        }
        //dataManager.Save(container);
    }
    public void LoadTasks()
    {
        //dataManager.Load();
    }
}
