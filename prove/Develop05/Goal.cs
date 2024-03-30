public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    protected bool Completed { get; set; }
    public int Points { get; private set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        Completed = false;
    }

  
    public virtual int GetPoints()
    {
        return Points;
    }


    public abstract void RecordEvent();
    public bool IsCompleted()
    {
        return Completed;
    }
}