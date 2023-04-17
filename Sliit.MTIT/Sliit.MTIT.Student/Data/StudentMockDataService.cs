namespace Sliit.MTIT.Student.Data
{
    public static class StudentMockDataService
    {
        public static List<Models.Student> Students = new List<Models.Student>()
        {
            new Models.Student { Id=1, Name = "Thirosh", Address = "Colombo", Age = 24},
            new Models.Student { Id=2, Name = "Sachini", Address = "Galle", Age = 23},
            new Models.Student { Id=3, Name = "Kasuni", Address = "Matara", Age = 22},
            new Models.Student { Id=4, Name = "Apsara", Address = "Kandy", Age = 21},
            new Models.Student { Id=5, Name = "Nethu", Address = "Gampaha", Age = 20},

        };
    }
}
