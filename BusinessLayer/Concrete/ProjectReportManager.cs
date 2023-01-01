using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectReportDtos;
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
    public class ProjectReportManager : ManagerBase, IProjectReportService
    {
        public ProjectReportManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectReportAddDto projectReportAddDto)
        {
            var projectReport = Mapper.Map<ProjectReport>(projectReportAddDto);
            await UnitOfWork.ProjectReport.AddAsync(projectReport);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectReportId)
        {
            var result = await UnitOfWork.ProjectReport.AnyAsync(a => a.Id == projectReportId);
            if (result)
            {
                var projectReport = await UnitOfWork.ProjectReport.GetAsync(a => a.Id == projectReportId);
                projectReport.IsActive = false;
                projectReport.IsDeleted = true;
                await UnitOfWork.ProjectReport.UpdateAsync(projectReport);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir proje bulunamadı.");
        }

        public async Task<IDataResult<ProjectReportListDto>> GetAll()
        {
            IQueryable<ProjectReport> query = UnitOfWork.ProjectReport.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.AppUser)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderBy(x => x.Completed).ThenBy(x => x.Project.FactoryDepartment.Factory.Name).ThenBy(x=>x.Project.Name); 
            var projectReports = await query.ToListAsync();
            if (projectReports != null)
            {
                return new DataResult<ProjectReportListDto>(ResultStatus.Success, new ProjectReportListDto
                {
                    ProjectReports = projectReports,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectReportListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }
        public async Task<IDataResult<ProjectReportListDto>> GetByFactory(int factoryId, int factoryId2, int factoryId3, int factoryId4)
        {
            IQueryable<ProjectReport> query = UnitOfWork.ProjectReport.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false && (x.Project.FactoryDepartment.FactoryId == factoryId || x.Project.FactoryDepartment.FactoryId == factoryId2 || x.Project.FactoryDepartment.FactoryId == factoryId3 || x.Project.FactoryDepartment.FactoryId == factoryId4))
               .Include(x => x.AppUser)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderBy(x => x.Completed).ThenBy(x => x.Project.FactoryDepartment.Factory.Name).ThenBy(x => x.Project.Name);

            var projectReports = await query.ToListAsync();
            if (projectReports != null)
            {
                return new DataResult<ProjectReportListDto>(ResultStatus.Success, new ProjectReportListDto
                {
                    ProjectReports = projectReports,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectReportListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectReportDto>> GetById(int projectReportId)
        {
            var projectReport = await UnitOfWork.ProjectReport.GetAsync(x => x.Id == projectReportId, x => x.Project.FactoryDepartment.Factory);
            if (projectReport != null)
            {
                return new DataResult<ProjectReportDto>(ResultStatus.Success, new ProjectReportDto
                {
                    ProjectReport = projectReport,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectReportDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }
        public async Task<IDataResult<ProjectReportDto>> GetByNote(string projectReportNote)
        {
            var projectReport = await UnitOfWork.ProjectReport.GetAsync(x => x.Note == projectReportNote, x => x.Project.FactoryDepartment.Factory);
            if (projectReport != null)
            {
                return new DataResult<ProjectReportDto>(ResultStatus.Success, new ProjectReportDto
                {
                    ProjectReport = projectReport,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectReportDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }
        public async Task<IResult> Update(ProjectReportUpdateDto projectReportUpdateDto)
        {
            var projectReport = Mapper.Map<ProjectReport>(projectReportUpdateDto);
            await UnitOfWork.ProjectReport.UpdateAsync(projectReport);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
