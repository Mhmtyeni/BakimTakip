using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dtos.RobotToBeMaintainedUserDtos
{
    public class RobotToBeMaintainedUserListDto : DtoGetBase
    {
        public IList<RobotToBeMaintainedUser> RobotToBeMaintainedUsers { get; set; }
    }
}
