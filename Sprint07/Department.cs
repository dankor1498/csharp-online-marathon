using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sprint07
{
    class Department
    {
        public Department(string name, int id, Worker manager)
        {
            Name = name;
            Id = id;
            Manager = manager;
        }

        public Department()
        {
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public Worker Manager { get; set; }
    }

    class Worker
    {
        private readonly JsonSerializerOptions options =
            new JsonSerializerOptions() { IgnoreNullValues = true, WriteIndented = true };

        public Worker(string name, decimal salary, Department department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public Worker()
        {
        }

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public string Serialize() 
        { 
            if (Department == null)
                return JsonSerializer.Serialize(new Worker(Name, Salary, null), options);

            return JsonSerializer.Serialize(new Worker(Name, Salary,
                  new Department(Department.Name, Department.Id,
                  new Worker(Department.Manager.Name, Department.Manager.Salary, null))), options);
        } 

        public static Worker Deserialize(string jsonInput) =>
            JsonSerializer.Deserialize<Worker>(jsonInput);
    }
}
