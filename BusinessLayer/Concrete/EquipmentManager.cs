using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentDtos;
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
    public class EquipmentManager : ManagerBase, IEquipmentService
    {
        public EquipmentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(EquipmentAddDto equipmentAddDto)
        {
            var equipment = Mapper.Map<Equipment>(equipmentAddDto);
            await UnitOfWork.Equipment.AddAsync(equipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int equipmentId)
        {
            var result = await UnitOfWork.Equipment.AnyAsync(a => a.Id == equipmentId);
            if (result)
            {
                var equipment = await UnitOfWork.Equipment.GetAsync(a => a.Id == equipmentId);
                await UnitOfWork.Equipment.DeleteAsync(equipment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ekipman bulunamadı.");
        }

        public async Task<IDataResult<EquipmentListDto>> GetAll()
        {
            IQueryable<Equipment> query = UnitOfWork.Equipment.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.EquipmentCategory);
            var equipment = await query.ToListAsync();
            if (equipment != null)
            {
                return new DataResult<EquipmentListDto>(ResultStatus.Success, new EquipmentListDto
                {
                    Equipments = equipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentListDto>(ResultStatus.Error, "Böyle bir ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentListDto>> GetByEquimentCategoryId(int equimentCategoryId)
        {
            IQueryable<Equipment> query = UnitOfWork.Equipment.GetAsQueryable();
            query = query.Where(x => x.EquipmentCategoryId == equimentCategoryId && x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.EquipmentCategory);
            var equipment = await query.ToListAsync();
            if (equipment != null)
            {
                return new DataResult<EquipmentListDto>(ResultStatus.Success, new EquipmentListDto
                {
                    Equipments = equipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentListDto>(ResultStatus.Error, "Böyle bir ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentDto>> GetById(int equipmentId)
        {
            var equipment = await UnitOfWork.Equipment.GetAsync(x => x.Id == equipmentId, x => x.EquipmentCategory);
            if (equipment != null)
            {
                return new DataResult<EquipmentDto>(ResultStatus.Success, new EquipmentDto
                {
                    Equipment = equipment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentDto>(ResultStatus.Error, "Böyle bir ekipman bulunamadı.", null);
        }

        public async Task<IResult> Update(EquipmentUpdateDto equipmentUpdateDto)
        {
            var equipment = Mapper.Map<Equipment>(equipmentUpdateDto);
            await UnitOfWork.Equipment.UpdateAsync(equipment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckNameExist(string name)
        {
            return await UnitOfWork.Equipment.AnyAsync(x => x.Name == name);
        }
        public async Task<IDataResult<EquipmentListDto>> SearchByKeyword(string keyword)
        {
            string normalizedKeyword = "";
            if (keyword != "")
                normalizedKeyword = keyword.ToLower();
            var query = UnitOfWork.Equipment.GetAsQueryable();
            query = query.Where(
            x => x.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.EquipmentCategory.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false)
                .Include(x => x.EquipmentCategory)
                .OrderByDescending(x => x.CreatedDate);
            var equipments = await query.ToListAsync();
            if (equipments != null)
            {
                return new DataResult<EquipmentListDto>(ResultStatus.Success, new EquipmentListDto
                {
                    Equipments = equipments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentListDto>(ResultStatus.Error, "Böyle bir ekipman bulunamadı.", null);
        }
    }
}
