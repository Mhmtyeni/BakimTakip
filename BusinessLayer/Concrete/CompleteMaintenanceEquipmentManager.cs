using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.CompleteMaintenanceEquipmentDtos;
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
    public class CompleteMaintenanceEquipmentManager : ManagerBase, ICompleteMaintenanceEquipmentService
    {
        public CompleteMaintenanceEquipmentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(CompleteMaintenanceEquipmentAddDto completeMaintenanceEquipmentAddDto)
        {
            var completeMaintenanceEquipment = Mapper.Map<CompleteMaintenanceEquipment>(completeMaintenanceEquipmentAddDto);
            await UnitOfWork.CompleteMaintenanceEquipment.AddAsync(completeMaintenanceEquipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int completeMaintenanceEquipmentId)
        {
            var result = await UnitOfWork.CompleteMaintenanceEquipment.AnyAsync(a => a.Id == completeMaintenanceEquipmentId);
            if (result)
            {
                var completeMaintenanceEquipment = await UnitOfWork.CompleteMaintenanceEquipment.GetAsync(a => a.Id == completeMaintenanceEquipmentId);
                completeMaintenanceEquipment.IsActive = false;
                completeMaintenanceEquipment.IsDeleted = true;
                await UnitOfWork.CompleteMaintenanceEquipment.UpdateAsync(completeMaintenanceEquipment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.");
        }

        public async Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetAll()
        {
            IQueryable<CompleteMaintenanceEquipment> query = UnitOfWork.CompleteMaintenanceEquipment.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.AppUser).
                Include(x => x.ProjectEquipment);
            var completeMaintenanceEquipment = await query.ToListAsync();
            if (completeMaintenanceEquipment != null)
            {
                return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Success, new CompleteMaintenanceEquipmentListDto
                {
                    CompleteMaintenanceEquipment = completeMaintenanceEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.", null);
        }
        public async Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetAllMounth()
        {
            IQueryable<CompleteMaintenanceEquipment> query = UnitOfWork.CompleteMaintenanceEquipment.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false && x.MaintenanceDate.Month == DateTime.Now.Month).
                Include(x => x.AppUser).
                Include(x => x.ProjectEquipment);
            var completeMaintenanceEquipment = await query.ToListAsync();
            if (completeMaintenanceEquipment != null)
            {
                return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Success, new CompleteMaintenanceEquipmentListDto
                {
                    CompleteMaintenanceEquipment = completeMaintenanceEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<CompleteMaintenanceEquipmentDto>> GetById(int completeMaintenanceEquipmentId)
        {
            var completeMaintenanceEquipment = await UnitOfWork.CompleteMaintenanceEquipment.GetAsync(x => x.Id == completeMaintenanceEquipmentId);
            if (completeMaintenanceEquipment != null)
            {
                return new DataResult<CompleteMaintenanceEquipmentDto>(ResultStatus.Success, new CompleteMaintenanceEquipmentDto
                {
                    CompleteMaintenanceEquipment = completeMaintenanceEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceEquipmentDto>(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<CompleteMaintenanceEquipmentListDto>> GetByProjectEquipmentId(int projectEquipmentId)
        {
            IQueryable<CompleteMaintenanceEquipment> query = UnitOfWork.CompleteMaintenanceEquipment.GetAsQueryable();
            query = query.Where(x => x.ProjectEquipmentId == projectEquipmentId && x.IsActive == true && x.IsDeleted == false);
            var completeMaintenanceEquipment = await query.ToListAsync();
            if (completeMaintenanceEquipment != null)
            {
                return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Success, new CompleteMaintenanceEquipmentListDto
                {
                    CompleteMaintenanceEquipment = completeMaintenanceEquipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompleteMaintenanceEquipmentListDto>(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.", null);
        }

        public async Task<IResult> Update(CompleteMaintenanceEquipmentUpdateDto completeMaintenanceEquipmentUpdateDto)
        {
            var completeMaintenanceEquipment = Mapper.Map<CompleteMaintenanceEquipment>(completeMaintenanceEquipmentUpdateDto);
            await UnitOfWork.CompleteMaintenanceEquipment.UpdateAsync(completeMaintenanceEquipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
