using ToDoTask = TelegramBotToDo.ToDoTask;

namespace TelegramBotToDoTests

{
    public class ToDoTaskTests
    {
        [Fact]
        public void Create_Test()
        {
            var expectedID = 1;
            var expectedUserID = 123;
            var name = "Write some code";
            var expectedStatus = true;

            ToDoTask toDoTask = new ToDoTask(expectedID, expectedUserID, name);
            var actualID = toDoTask.ID;
            var actualUserID = toDoTask.UserID;
            var actualName = toDoTask.Name;
            var actualStatus = toDoTask.Status;

            Assert.Equal(expectedID, actualID);
            Assert.Equal(expectedUserID, actualUserID);
            Assert.NotNull(actualName);
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void Create_Test_With_Date_And_Priority()
        {
            var expectedID = 1;
            var expectedUserID = 123;
            var name = "Write some code";
            var dateTime = DateTime.Now;
            var priority = "Top";
            var expectedStatus = true;

            ToDoTask toDoTask = new ToDoTask(expectedID, expectedUserID, name, dateTime, priority);
            var actualID = toDoTask.ID;
            var actualUserID = toDoTask.UserID;
            var actualName = toDoTask.Name;
            var actualStatus = toDoTask.Status;
            var actualDeadLine = toDoTask.DeadLine;
            var actualPriority = toDoTask.Priority;

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
            var ID = 1;
            var userID = 123;
            var name = "Write some code";
            var dateTime = DateTime.Now;
            var priority = "Top";
            ToDoTask toDoTask = new ToDoTask(ID, userID, name, dateTime, priority);
            
            toDoTask.Close();
            var actualStatus = toDoTask.Status;

            Assert.False(actualStatus);
        }

        [Fact]
        public void Update_Test()
        {
            var ID = 1;
            var userID = 123;
            var name = "Write some code";
            var dateTime = DateTime.Now;
            var priority = "Top";
            ToDoTask toDoTask = new ToDoTask(ID, userID, name, dateTime, priority);

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