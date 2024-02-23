using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoSystem : MonoBehaviour
{
    public ToDoSystem Instance { get; private set; }

    private List<TaskItem> TaskItems;

    private void Awake()
    {
        Instance = this; 
    }
    private void Start()
    {
        TaskItems=LoadTasks();
    }
    public void SaveTasks(List<TaskItem> tasks)
    {
        string jsonTasks = JsonUtility.ToJson(tasks);
        PlayerPrefs.SetString("Tasks", jsonTasks);
        PlayerPrefs.Save();
    }
    public List<TaskItem> GetTasks()
    {
        return TaskItems;
    }
    private List<TaskItem> LoadTasks()
    {
        string jsonTasks = PlayerPrefs.GetString("Tasks");
        if (!string.IsNullOrEmpty(jsonTasks))
        {
            return JsonUtility.FromJson<List<TaskItem>>(jsonTasks);
        }
        else
        {
            return new List<TaskItem>();
        }
    }
}
