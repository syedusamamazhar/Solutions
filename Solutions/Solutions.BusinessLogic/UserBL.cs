using Solutions.DataAccess;
using Solutions.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.BusinessLogic
{
    public class UserBL
    {

        public static User GetUser(string userName)
        {
            using (BaseRepository baseRepository = new BaseRepository())
            {
                //return baseRepository.Get<User>().Where(p => p.Name == userName).FirstOrDefault();
                return baseRepository.GetIncluding<User>(p => p.SatisfactoryLevel).Where(p => p.Name.ToUpper() == userName.ToUpper()).FirstOrDefault();
            }
        }
    }
}
