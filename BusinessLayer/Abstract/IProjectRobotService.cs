using EntityLayer.Dtos.ProjectRobotDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectRobotService
    {
        public Task<IResult> Add(ProjectRobotAddDto projectRobotAddDto);
        public Task<IResult> Update(ProjectRobotUpdateDto projectRobotUpdateDto);
        public Task<IResult> DeleteById(int projectRobotId);
        public Task<IDataResult<ProjectRobotListDto>> GetAll();
        public Task<IDataResult<ProjectRobotDto>> GetById(int projectRobotId);
        public Task<IDataResult<ProjectRobotListDto>> GetByProjectId(int projectId);
        public Task<IDataResult<ProjectRobotListDto>> GetByRobotId(int robotId);

    }
}
