using System.Collections.Generic;

namespace MediatorPattern_After
{
    public class User
    {
        public string Name;
        public ChatRoom ChatRoom;

        public void SendAsWhisper(string message, User targetUser)
        {
            ChatRoom.Whisper(this, message, targetUser);
        }

        public void Send(string message)
        {
            ChatRoom.Send(this, message);
        }

        public void DisplayMessage(string message)
        {
        }
    }

    public class ChatRoom
    {
        private List<User> Users = new List<User>();

        public void Send(User asUser, string message)
        {
            foreach (var user in Users)
            {
                user.DisplayMessage(asUser.Name + " : " + message);
            }
        }

        public void Whisper(User asUser, string message, User toUser)
        {
            asUser.DisplayMessage( asUser.Name + " whispering to " + toUser + " : " + message);
            toUser.DisplayMessage( asUser.Name + " whispered : " + message);
        }
    }
}