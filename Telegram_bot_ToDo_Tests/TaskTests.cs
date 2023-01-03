using Task = TelegramBotToDo.Task;

namespace TelegramBotToDoTests

{
    public class TaskTests
    {
        [Fact]
        public void Create_Test()
        {
            Task task = new Task(1, 123, "Write some code");

            int expectedID = 1;
            int expectedUserID = 123;
            bool expectedStatus = true;

            int actualID = task.ID;
            int actualUserID = task.UserID;
            string actualName = task.Name;
            bool actualStatus = task.Status;

            Assert.Equal(expectedID, actualID);
            Assert.Equal(expectedUserID, actualUserID);
            Assert.NotNull(actualName);
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void Create_Test_With_Date_And_Priority()
        {
            Task task = new Task(1, 123, "Write some code", DateTime.Now, "Top");

            int expectedID = 1;
            int expectedUserID = 123;
            bool expectedStatus = true;

            int actualID = task.ID;
            int actualUserID = task.UserID;
            string actualName = task.Name;
            bool actualStatus = task.Status;

            DateTime? actualDeadLine = task.DeadLine;
            string actualPriority = task.Priority;

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
            Task task = new Task(1, 123, "Write some code", DateTime.Now, "Top");
            
            task.Close();
            bool actualStatus = task.Status;

            Assert.False(actualStatus);
        }

        [Fact]
        public void Change_Test()
        {
            Task task = new Task(1, 123, "Write some code", DateTime.Now, "Top");
            var nameToChange = "Go to sleep";
            var deadLineToChange = new DateTime(2023, 1, 10, 12, 0, 0);
            var priorityToChange = "Low";
            var statusToChange = false;

            task.Change(nameToChange, deadLineToChange, priorityToChange, statusToChange);
            string? actualName = task.Name;
            DateTime? actualDeadLine = task.DeadLine;
            string? actualPriority = task.Priority;
            bool? actualStatus = task.Status;

            Assert.Equal(nameToChange, actualName);
            Assert.Equal(deadLineToChange, actualDeadLine);
            Assert.Equal(priorityToChange, actualPriority);
            Assert.Equal(statusToChange, actualStatus);
        }
    
    }


}