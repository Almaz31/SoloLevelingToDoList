[System.Serializable]
public class TaskItem
{
    public string taskName;
    public bool isCompleted;
    public int repeatCount;
    public int difficulity;

    public TaskItem(string name, int repeats,int difficult)
    {
        taskName = name;
        isCompleted = false;
        difficulity = difficult;
        repeatCount = repeats;
    }
    public void SetCompleted()
    {
        isCompleted = true;
    }
}
