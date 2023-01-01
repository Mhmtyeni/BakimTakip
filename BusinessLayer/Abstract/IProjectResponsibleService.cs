using EntityLayer.Dtos.ProjectResponsibleDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectResponsibleService
    {
        public Task<IResult> Add(ProjectResponsibleAddDto projectResponsibleAddDto);
        public Task<IResult> Update(ProjectResponsibleUpdateDto projectResponsibleUpdateDto);
        public Task<IResult> DeleteById(int projectResponsibleId);
        public Task<IDataResult<ProjectResponsibleListDto>> GetAll();
        public Task<IDataResult<ProjectResponsibleDto>> GetById(int projectResponsibleId);
        public Task<IDataResult<ProjectResponsibleListDto>> GetByUserId(int userId);
        public Task<IDataResult<ProjectResponsibleListDto>> GetByProjectId(int projectId);
        public Task<bool> CheckUserExist(int userId,int projectId);
    }
}
