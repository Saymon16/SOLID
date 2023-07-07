using System.Collections.Generic;

namespace MediatorPattern_Before
{
    public class User
    {
        public string Name;
        public List<User> AllUsersInChat;

        public void Send(string message)
        {
            foreach (var user in AllUsersInChat)
            {
                user.DisplayMessage(Name + " : " + message);
            }
        }
       
        public void SendAsWhisper(string message, User targetUser)
        {
            DisplayMessage( Name + " whispering to " + targetUser + " : " + message);
            targetUser.DisplayMessage(Name + " whispered : " + message);
        }

        public void DisplayMessage(string message)
        {
        }
    }
}