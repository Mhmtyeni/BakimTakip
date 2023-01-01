using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FaultReportDtos;
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
    public class FaultReportManager : ManagerBase, IFaultReportService
    {
        public FaultReportManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(FaultReportAddDto faultReportAddDto)
        {
            var faultReport = Mapper.Map<FaultReport>(faultReportAddDto);
            await UnitOfWork.FaultReport.AddAsync(faultReport);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int faultReportId)
        {
            var result = await UnitOfWork.FaultReport.AnyAsync(a => a.Id == faultReportId);
            if (result)
            {
                var faultReport = await UnitOfWork.FaultReport.GetAsync(a => a.Id == faultReportId);
                faultReport.IsActive = false;
                faultReport.IsDeleted = true;
                await UnitOfWork.FaultReport.UpdateAsync(faultReport);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir arıza bulunamadı.");
        }

        public async Task<IDataResult<FaultReportListDto>> GetAll()
        {
            IQueryable<FaultReport> query = UnitOfWork.FaultReport.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.AppUser)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderBy(x => x.Completed).ThenBy(x => x.Project.FactoryDepartment.Factory.Name).ThenBy(x => x.Project.Name);
            var faultReports = await query.ToListAsync();
            if (faultReports != null)
            {
                return new DataResult<FaultReportListDto>(ResultStatus.Success, new FaultReportListDto
                {
                    FaultReports = faultReports,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FaultReportListDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }
        public async Task<IDataResult<FaultReportListDto>> GetByFactory(int factoryId, int factoryId2, int factoryId3, int factoryId4)
        {
            IQueryable<FaultReport> query = UnitOfWork.FaultReport.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false && (x.Project.FactoryDepartment.FactoryId == factoryId || x.Project.FactoryDepartment.FactoryId == factoryId2 || x.Project.FactoryDepartment.FactoryId == factoryId3 || x.Project.FactoryDepartment.FactoryId == factoryId4))
                .Include(x => x.AppUser)
                .Include(x => x.Project)
                .ThenInclude(x => x.FactoryDepartment)
                .ThenInclude(x => x.Factory).OrderBy(x => x.Completed).ThenBy(x => x.Project.FactoryDepartment.Factory.Name).ThenBy(x => x.Project.Name);
            var faultReports = await query.ToListAsync();
            if (faultReports != null)
            {
                return new DataResult<FaultReportListDto>(ResultStatus.Success, new FaultReportListDto
                {
                    FaultReports = faultReports,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FaultReportListDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }

        public async Task<IDataResult<FaultReportDto>> GetById(int faultReportId)
        {
            var faultReport = await UnitOfWork.FaultReport.GetAsync(x => x.Id == faultReportId, x => x.Project.FactoryDepartment.Factory);
            if (faultReport != null)
            {
                return new DataResult<FaultReportDto>(ResultStatus.Success, new FaultReportDto
                {
                    FaultReport = faultReport,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FaultReportDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }
        public async Task<IDataResult<FaultReportDto>> GetByNote(string faultReportNote)
        {
            var faultReport = await UnitOfWork.FaultReport.GetAsync(x => x.Note == faultReportNote, x => x.Project.FactoryDepartment.Factory);
            if (faultReport != null)
            {
                return new DataResult<FaultReportDto>(ResultStatus.Success, new FaultReportDto
                {
                    FaultReport = faultReport,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FaultReportDto>(ResultStatus.Error, "Böyle bir arıza bulunamadı.", null);
        }

        public async Task<IResult> Update(FaultReportUpdateDto faultReportUpdateDto)
        {
            var faultReport = Mapper.Map<FaultReport>(faultReportUpdateDto);
            await UnitOfWork.FaultReport.UpdateAsync(faultReport);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
