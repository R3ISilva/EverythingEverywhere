namespace Bussiness
{
    public class UserEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public static List<UserEntity> GetAllUsersList()
        {
            List<UserEntity> userList = new List<UserEntity>();

            //TODO: GET USERS FROM DATABASE
            userList.Add(new UserEntity { UserID = 1, UserName = "João" });
            userList.Add(new UserEntity { UserID = 2, UserName = "Edgar" });
            userList.Add(new UserEntity { UserID = 3, UserName = "Rato" });

            return userList;
        }
    }
}