using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LoginUser
{
    public class User
    {
        private List<Identity> users = new List<Identity>();

        // Load users from JSON file
        public void LoadUsersFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<Identity>>(json);
            }
        }

        // Validate credentials
        public bool IsValid(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
