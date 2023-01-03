using ToDoTask = TelegramBotToDo.ToDoTask;

namespace TelegramBotToDoTests

{
    public class ToDoTaskTests
    {
        [Fact]
        public void Create_Test()
        {
            ToDoTask toDoTask = new ToDoTask(1, 123, "Write some code");

            int expectedID = 1;
            int expectedUserID = 123;
            bool expectedStatus = true;

            int actualID = toDoTask.ID;
            int actualUserID = toDoTask.UserID;
            string actualName = toDoTask.Name;
            bool actualStatus = toDoTask.Status;

            Assert.Equal(expectedID, actualID);
            Assert.Equal(expectedUserID, actualUserID);
            Assert.NotNull(actualName);
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void Create_Test_With_Date_And_Priority()
        {
            ToDoTask toDoTask = new ToDoTask(1, 123, "Write some code", DateTime.Now, "Top");

            int expectedID = 1;
            int expectedUserID = 123;
            bool expectedStatus = true;

            int actualID = toDoTask.ID;
            int actualUserID = toDoTask.UserID;
            string actualName = toDoTask.Name;
            bool actualStatus = toDoTask.Status;

            DateTime? actualDeadLine = toDoTask.DeadLine;
            string actualPriority = toDoTask.Priority;

            Assert.Equal(expectedID, actualID);
            Assert.Equal(expectedUserID, actualUserID);
            Assert.NotNull(actualName);
            Assert.Equal(expectedStatus, actualStatus);

            Assert.NotNull(actualDeadLine);
            Assert.NotNull(actualPriority);
        }

        [Fact]
        public void Close_Test()
        {
            ToDoTask toDoTask = new ToDoTask(1, 123, "Write some code", DateTime.Now, "Top");
            
            toDoTask.Close();
            bool actualStatus = toDoTask.Status;

            Assert.False(actualStatus);
        }

        [Fact]
        public void Update_Test()
        {
            ToDoTask toDoTask = new ToDoTask(1, 123, "Write some code", DateTime.Now, "Top");
            var nameToChange = "Go to sleep";
            var deadLineToChange = new DateTime(2023, 1, 10, 12, 0, 0);
            var priorityToChange = "Low";
            var statusToChange = false;

            toDoTask.Update(nameToChange, deadLineToChange, priorityToChange, statusToChange);
            string? actualName = toDoTask.Name;
            DateTime? actualDeadLine = toDoTask.DeadLine;
            string? actualPriority = toDoTask.Priority;
            bool? actualStatus = toDoTask.Status;

            Assert.Equal(nameToChange, actualName);
            Assert.Equal(deadLineToChange, actualDeadLine);
            Assert.Equal(priorityToChange, actualPriority);
            Assert.Equal(statusToChange, actualStatus);
        }
    
    }


}