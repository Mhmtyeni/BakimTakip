using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.EquipmentCategoryDtos;
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
    public class EquipmentCategoryManager : ManagerBase, IEquipmentCategoryService
    {
        public EquipmentCategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(EquipmentCategoryAddDto equipmentCategoryAddDto)
        {
            var equipmentCategory = Mapper.Map<EquipmentCategory>(equipmentCategoryAddDto);
            await UnitOfWork.EquipmentCategory.AddAsync(equipmentCategory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int equipmentCategoryById)
        {
            var result = await UnitOfWork.EquipmentCategory.AnyAsync(a => a.Id == equipmentCategoryById);
            if (result)
            {
                var equipmentCategory = await UnitOfWork.EquipmentCategory.GetAsync(a => a.Id == equipmentCategoryById);
                equipmentCategory.IsActive = false;
                equipmentCategory.IsDeleted = true;
                await UnitOfWork.EquipmentCategory.DeleteAsync(equipmentCategory);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir ekipman kategorisi bulunamadı.");
        }

        public async Task<IDataResult<EquipmentCategoryListDto>> GetAll()
        {
            var equipmentCategory = await UnitOfWork.EquipmentCategory.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false);
            if (equipmentCategory != null)
            {
                return new DataResult<EquipmentCategoryListDto>(ResultStatus.Success, new EquipmentCategoryListDto
                {
                    EquipmentCategories = equipmentCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentCategoryListDto>(ResultStatus.Error, "Böyle bir ekipman kategorisi bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentCategoryDto>> GetById(int equipmentCategoryId)
        {
            var equipmentCategory = await UnitOfWork.EquipmentCategory.GetAsync(x => x.Id == equipmentCategoryId);
            if (equipmentCategory != null)
            {
                return new DataResult<EquipmentCategoryDto>(ResultStatus.Success, new EquipmentCategoryDto
                {
                    EquipmentCategory = equipmentCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentCategoryDto>(ResultStatus.Error, "Böyle bir ekipman kategorisi bulunamadı.", null);
        }

        public async Task<IDataResult<EquipmentCategoryListDto>> GetBySubId(int subId)
        {
            IQueryable<EquipmentCategory> query = UnitOfWork.EquipmentCategory.GetAsQueryable();
            query = query.Where(x => x.SubId == subId && x.IsActive == true && x.IsDeleted == false)
                .Include(x=>x.Equipment);
            var equipmentCategory = await query.ToListAsync();
            if (equipmentCategory != null)
            {
                return new DataResult<EquipmentCategoryListDto>(ResultStatus.Success, new EquipmentCategoryListDto
                {
                    EquipmentCategories = equipmentCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EquipmentCategoryListDto>(ResultStatus.Error, "Böyle bir ekipman kategorisi bulunamadı.", null);
        }

        public async Task<IResult> Update(EquipmentCategoryUpdateDto equipmentCategoryUpdateDto)
        {
            var equipmentCategory = Mapper.Map<EquipmentCategory>(equipmentCategoryUpdateDto);
            await UnitOfWork.EquipmentCategory.UpdateAsync(equipmentCategory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
