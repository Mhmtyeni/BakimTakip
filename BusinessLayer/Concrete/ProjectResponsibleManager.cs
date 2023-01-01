using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectResponsibleDtos;
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
    public class ProjectResponsibleManager : ManagerBase, IProjectResponsibleService
    {
        public ProjectResponsibleManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectResponsibleAddDto projectResponsibleAddDto)
        {
            var projectResponsible = Mapper.Map<ProjectResponsible>(projectResponsibleAddDto);
            await UnitOfWork.ProjectResponsible.AddAsync(projectResponsible);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectResponsibleId)
        {
            var result = await UnitOfWork.ProjectResponsible.AnyAsync(a => a.Id == projectResponsibleId);
            if (result)
            {
                var projectResponsible = await UnitOfWork.ProjectResponsible.GetAsync(a => a.Id == projectResponsibleId);
                projectResponsible.IsActive = false;
                projectResponsible.IsDeleted = true;
                await UnitOfWork.ProjectResponsible.UpdateAsync(projectResponsible);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir sorumlu bulunamadı.");
        }

        public async Task<IDataResult<ProjectResponsibleListDto>> GetAll()
        {
            IQueryable<ProjectResponsible> query = UnitOfWork.ProjectResponsible.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.AppUser).
                Include(x => x.ProjectId);
            var projectResponsibles = await query.ToListAsync();
            if (projectResponsibles != null)
            {
                return new DataResult<ProjectResponsibleListDto>(ResultStatus.Success, new ProjectResponsibleListDto
                {
                    ProjectResponsibles = projectResponsibles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectResponsibleListDto>(ResultStatus.Error, "Böyle bir sorumlu bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectResponsibleDto>> GetById(int projectResponsibleId)
        {
            var projectResponsible = await UnitOfWork.ProjectResponsible.GetAsync(x => x.Id == projectResponsibleId);
            if (projectResponsible != null)
            {
                return new DataResult<ProjectResponsibleDto>(ResultStatus.Success, new ProjectResponsibleDto
                {
                    ProjectResponsible = projectResponsible,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectResponsibleDto>(ResultStatus.Error, "Böyle bir sorumlu bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectResponsibleListDto>> GetByProjectId(int projectId)
        {
            IQueryable<ProjectResponsible> query = UnitOfWork.ProjectResponsible.GetAsQueryable();
            query = query.Where(x => x.ProjectId == projectId && x.IsActive == true && x.IsDeleted == false);
            var projectResponsibles = await query.ToListAsync();
            if (projectResponsibles != null)
            {
                return new DataResult<ProjectResponsibleListDto>(ResultStatus.Success, new ProjectResponsibleListDto
                {
                    ProjectResponsibles = projectResponsibles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectResponsibleListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectResponsibleListDto>> GetByUserId(int userId)
        {
            IQueryable<ProjectResponsible> query = UnitOfWork.ProjectResponsible.GetAsQueryable();
            query = query.Where(x => x.AppUserId == userId && x.IsActive == true && x.IsDeleted == false);
            var projectResponsibles = await query.ToListAsync();
            if (projectResponsibles != null)
            {
                return new DataResult<ProjectResponsibleListDto>(ResultStatus.Success, new ProjectResponsibleListDto
                {
                    ProjectResponsibles = projectResponsibles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectResponsibleListDto>(ResultStatus.Error, "Böyle bir sorumlu bulunamadı.", null);
        }

        public async Task<IResult> Update(ProjectResponsibleUpdateDto projectResponsibleUpdateDto)
        {
            var projectResponsible = Mapper.Map<ProjectResponsible>(projectResponsibleUpdateDto);
            await UnitOfWork.ProjectResponsible.UpdateAsync(projectResponsible);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckUserExist(int userId, int projectId)
        {
            return await UnitOfWork.ProjectResponsible.AnyAsync(x => x.AppUserId == userId && x.ProjectId == projectId);
        }
    }
}
