using System.Data;

namespace FootballPro.Entity
{
    public class San
    {
        private int iD;
        private string name;
        private string location;
        private string status;
        
        public San() { }

        public San(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.location = row["location"].ToString();
            this.Status = row["status"].ToString();
        }

        public San(int iD, string name,string location, string status)
        {
            this.ID = iD;
            this.Name = name;
            this.location = location;
            this.Status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Status { get => status; set => status = value; }
    }
}
