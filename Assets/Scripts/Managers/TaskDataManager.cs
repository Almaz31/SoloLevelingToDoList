using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TaskDataManager 
{
    private string fileName = "TaskData.txt";

    public void Save( TaskContainer taskContainer)
    {
        WriteToFile(taskContainer);
    }
    public string Load()
    {
        Debug.Log(LoadFromFile());
        return LoadFromFile();
    }
    private void WriteToFile(TaskContainer taskContainer)
    {
        string path = GetFilePath();

        FileStream fileStream = new FileStream(path, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine(JsonUtility.ToJson(taskContainer.items));
        }
    }
    private string LoadFromFile()
    {
        string path = GetFilePath();

        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
        else
        {
            return "";
        }

    }
    private string GetFilePath()
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
