using System;

class Program
{
    static void Main()
    {
        EternalQuestProgram questProgram = new EternalQuestProgram();

        questProgram.AddGoal(new SimpleGoal("Run a Marathon", 100, 1));
        questProgram.AddGoal(new EternalGoal("Read Scriptures", 50, 1));
        questProgram.AddGoal(new ChecklistGoal("Attend Temple", 25, 1, 10));

        questProgram.RecordEvent(0);
        questProgram.RecordEvent(1);
        questProgram.RecordEvent(2);
        questProgram.RecordEvent(2);
        questProgram.RecordEvent(2);
        questProgram.RecordEvent(2);
        questProgram.RecordEvent(2);

        questProgram.DisplayGoals();
        questProgram.DisplayScore();

        questProgram.SaveProgress();
        questProgram.LoadProgress();
    }
}