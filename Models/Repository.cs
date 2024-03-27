namespace MeetingApp.Models
{
    public class Repository{
        private static List<UserInfo> _users = new();

        public static List<UserInfo> Users{
            get {
                return _users;
            }
        }
        static Repository(){
            _users.Add(new UserInfo(){id=1, Name ="Alperen", Email="abc@gmail.com",Phone="12345",WillAttend=true});
            
            _users.Add(new UserInfo(){id=2, Name ="Tuana", Email="abcd@gmail.com",Phone="22345",WillAttend=false});
            
            _users.Add(new UserInfo(){id=3, Name ="Mehmet", Email="abce@gmail.com",Phone="32345",WillAttend=true});
            
        }
        public static void CreateUser(UserInfo user){
            user.id = Users.Count+1;
            _users.Add(user);
        }
        public static UserInfo? getById(int id){
            return _users.FirstOrDefault(i=>i.id==id);
        }
    }
}