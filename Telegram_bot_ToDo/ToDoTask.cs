namespace TelegramBotToDo;

public sealed class ToDoTask
{
    public ToDoTask(int id, int userID, string name)
    {
        ID = id;
        UserID = userID;
        Name = name;
        Status = true;
    }

    public ToDoTask (int id, int userID, string name, DateTime deadLine, string priority) : this(id, userID, name)
    {
        DeadLine = deadLine;
        Priority = priority;
    }

    public int ID { get; private set; }
    public int UserID { get; private set; }
    public string Name { get; private set; }
    public DateTime? DeadLine { get; private set; }
    public string? Priority { get; private set; }
    public bool Status { get; private set; }

    public void Close()
    {
        if(Status)
        {
            Status = false;
        }
    }
    
    public void Update(string? name = null,
                       DateTime? deadLine = null,
                       string? priority = null,
                       bool? status = null)
    {
        if(name != null)
        {
            Name = name;
        }
        
        if(deadLine != null) 
        {
            DeadLine = deadLine;
        }

        if(priority != null)
        {
            Priority = priority;
        }

        if(status != null)
        {
            Status = status.Value;
        }
    }
}