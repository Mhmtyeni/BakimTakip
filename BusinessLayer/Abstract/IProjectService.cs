﻿using EntityLayer.Dtos.ProjectDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectService
    {
        public Task<IResult> Add(ProjectAddDto projectAddDto);
        public Task<IResult> Update(ProjectUpdateDto projectUpdateDto);
        public Task<IResult> DeleteById(int projectId);
        public Task<IDataResult<ProjectListDto>> GetAll();
        public Task<IDataResult<ProjectDto>> GetById(int projectId);
        public Task<IDataResult<ProjectDto>> SelectGetById(int projectId);
        public Task<IDataResult<ProjectListDto>> GetByFactoryDepartmentId(int factoryDepartmentId);
        public Task<IDataResult<ProjectListDto>> SearchByKeyword(string keyword);
    }
}
