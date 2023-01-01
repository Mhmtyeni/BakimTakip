using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : ManagerBase, IProjectService
    {
        public ProjectManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectAddDto projectAddDto)
        {
            var project = Mapper.Map<Project>(projectAddDto);
            await UnitOfWork.Project.AddAsync(project);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectId)
        {
            var result = await UnitOfWork.Project.AnyAsync(a => a.Id == projectId);
            if (result)
            {
                var project = await UnitOfWork.Project.GetAsync(a => a.Id == projectId);
                project.IsActive = false;
                project.IsDeleted = true;
                await UnitOfWork.Project.UpdateAsync(project);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir proje bulunamadı.");
        }

        public async Task<IDataResult<ProjectListDto>> GetAll()
        {
            IQueryable<Project> query = UnitOfWork.Project.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.FactoryDepartment).ThenInclude(x => x.Factory);
            var projects = await query.ToListAsync();
            if (projects != null)
            {
                return new DataResult<ProjectListDto>(ResultStatus.Success, new ProjectListDto
                {
                    Projects = projects,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectListDto>> GetByFactoryDepartmentId(int factoryDepartmentId)
        {
            IQueryable<Project> query = UnitOfWork.Project.GetAsQueryable();
            query = query.Where(x => x.FactoryDepartmentId == factoryDepartmentId && x.IsActive == true && x.IsDeleted == false);
            var projects = await query.ToListAsync();
            if (projects != null)
            {
                return new DataResult<ProjectListDto>(ResultStatus.Success, new ProjectListDto
                {
                    Projects = projects,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectListDto>(ResultStatus.Error, "Böyle bir bölüm bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectDto>> GetById(int projectId)
        {
            var project = await UnitOfWork.Project.GetAsync(x => x.Id == projectId, x => x.FactoryDepartment, x => x.ProjectEquipment, x => x.ProjectRobots, x => x.ProjectResponsibles);
            if (project != null)
            {
                return new DataResult<ProjectDto>(ResultStatus.Success, new ProjectDto
                {
                    Project = project,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }
        public async Task<IDataResult<ProjectDto>> SelectGetById(int projectId)
        {
            var project = await UnitOfWork.Project.GetAsync(x => x.Id == projectId,x=>x.FactoryDepartment.Factory ,x => x.FactoryDepartment, x => x.ProjectEquipment, x => x.ProjectRobots, x => x.ProjectResponsibles);
            if (project != null)
            {
                return new DataResult<ProjectDto>(ResultStatus.Success, new ProjectDto
                {
                    Project = project,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IResult> Update(ProjectUpdateDto projectUpdateDto)
        {
            var project = Mapper.Map<Project>(projectUpdateDto);
            await UnitOfWork.Project.UpdateAsync(project);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<IDataResult<ProjectListDto>> SearchByKeyword(string keyword)
        {
            string normalizedKeyword = "";
            if (keyword != "")
                normalizedKeyword = keyword.ToLower();
            var query = UnitOfWork.Project.GetAsQueryable();
            query = query.Where(
            x => x.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.FactoryDepartment).ThenInclude(x => x.Factory)
                .OrderByDescending(x => x.CreatedDate);
            var projects = await query.ToListAsync();
            if (projects != null)
            {
                return new DataResult<ProjectListDto>(ResultStatus.Success, new ProjectListDto
                {
                    Projects = projects,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }
    }
}
