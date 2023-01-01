using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectEquipmentDtos;
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
    public class ProjectEquipmentManager : ManagerBase, IProjectEquipmentService
    {
        public ProjectEquipmentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectEquipmentAddDto projectEquipmentAddDto)
        {
            var projectEquipment = Mapper.Map<ProjectEquipment>(projectEquipmentAddDto);
            await UnitOfWork.ProjectEquipment.AddAsync(projectEquipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectEquipmentId)
        {
            var result = await UnitOfWork.ProjectEquipment.AnyAsync(a => a.Id == projectEquipmentId);
            if (result)
            {
                var projectEquipment = await UnitOfWork.ProjectEquipment.GetAsync(a => a.Id == projectEquipmentId);
                projectEquipment.IsActive = false;
                projectEquipment.IsDeleted = true;
                await UnitOfWork.ProjectEquipment.UpdateAsync(projectEquipment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.");
        }

        public async Task<IDataResult<ProjectEquipmentListDto>> GetAll()
        {
            IQueryable<ProjectEquipment> query = UnitOfWork.ProjectEquipment.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.Equipment).
                Include(x => x.Project);
            var projectEquipment = await query.ToListAsync();
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentListDto>(ResultStatus.Success, new ProjectEquipmentListDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentListDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectEquipmentListDto>> GetByEquipmentId(int equipmentId)
        {
            IQueryable<ProjectEquipment> query = UnitOfWork.ProjectEquipment.GetAsQueryable();
            query = query.Where(x => x.EquipmentId == equipmentId && x.IsActive == true && x.IsDeleted == false).Include(x => x.Equipment);
            var projectEquipment = await query.ToListAsync();
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentListDto>(ResultStatus.Success, new ProjectEquipmentListDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentListDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectEquipmentDto>> GetById(int projectEquipmentId)
        {
            var projectEquipment = await UnitOfWork.ProjectEquipment.GetAsync(x => x.Id == projectEquipmentId);
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentDto>(ResultStatus.Success, new ProjectEquipmentDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectEquipmentListDto>> GetByProjectId(int projectId)
        {
            IQueryable<ProjectEquipment> query = UnitOfWork.ProjectEquipment.GetAsQueryable();
            query = query.Where(x => x.ProjectId == projectId && x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.Equipment)
                .ThenInclude(x => x.EquipmentCategory)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderByDescending(x => x.EquipmentId);
            var projectEquipment = await query.ToListAsync();
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentListDto>(ResultStatus.Success, new ProjectEquipmentListDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentListDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }
        public async Task<IDataResult<ProjectEquipmentListDto>> GetByProjectEquipmentId(int equipmentId)
        {
            IQueryable<ProjectEquipment> query = UnitOfWork.ProjectEquipment.GetAsQueryable();
            query = query.Where(x => x.EquipmentId == equipmentId && x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.Equipment)
                .ThenInclude(x => x.EquipmentCategory)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderByDescending(x => x.ProjectId);
            var projectEquipment = await query.ToListAsync();
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentListDto>(ResultStatus.Success, new ProjectEquipmentListDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentListDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }
        public async Task<IDataResult<ProjectEquipmentListDto>> GetAllEquipment(int projectId)
        {
            IQueryable<ProjectEquipment> query = UnitOfWork.ProjectEquipment.GetAsQueryable();
            query = query.Where(x => x.ProjectId == projectId && x.IsActive == true && x.IsDeleted == false && x.CheckMaintenance == false)
                .Include(x => x.Equipment)
                .Include(x => x.Project);
            var projectEquipment = await query.ToListAsync();
            if (projectEquipment != null)
            {
                return new DataResult<ProjectEquipmentListDto>(ResultStatus.Success, new ProjectEquipmentListDto
                {
                    ProjectEquipment = projectEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectEquipmentListDto>(ResultStatus.Error, "Böyle bir proje ekipmanı bulunamadı.", null);
        }

        public async Task<IResult> Update(ProjectEquipmentUpdateDto projectEquipmentUpdateDto)
        {
            var projectEquipment = Mapper.Map<ProjectEquipment>(projectEquipmentUpdateDto);
            await UnitOfWork.ProjectEquipment.UpdateAsync(projectEquipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
