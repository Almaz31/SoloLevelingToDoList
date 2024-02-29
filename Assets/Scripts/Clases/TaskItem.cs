[System.Serializable]
public class TaskItem
{
    public string taskName;
    public bool isCompleted;
    public int repeatCount;

    public TaskItem(string name, int repeats)
    {
        taskName = name;
        isCompleted = false;
        repeatCount = repeats;
    }
    public void SetCompleted()
    {
        isCompleted = true;
    }
}
