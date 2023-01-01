using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotCategoryDtos;
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
    public class RobotCategoryManager : ManagerBase, IRobotCategoryService
    {
        public RobotCategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(RobotCategoryAddDto robotCategoryAddDto)
        {
            var robotCategory = Mapper.Map<RobotCategory>(robotCategoryAddDto);
            await UnitOfWork.RobotCategory.AddAsync(robotCategory);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int robotCategoryId)
        {
            var result = await UnitOfWork.RobotCategory.AnyAsync(a => a.Id == robotCategoryId);
            if (result)
            {
                var robotCategory = await UnitOfWork.RobotCategory.GetAsync(a => a.Id == robotCategoryId);
                robotCategory.IsActive = false;
                robotCategory.IsDeleted = true;
                await UnitOfWork.RobotCategory.UpdateAsync(robotCategory);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı.");
        }

        public async Task<IDataResult<RobotCategoryListDto>> GetAll()
        {
            var robotCategories = await UnitOfWork.RobotCategory.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false);
            if (robotCategories != null)
            {
                return new DataResult<RobotCategoryListDto>(ResultStatus.Success, new RobotCategoryListDto
                {
                    RobotCategories = robotCategories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotCategoryListDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<RobotCategoryDto>> GetById(int robotCategoryId)
        {
            var robotCategory = await UnitOfWork.RobotCategory.GetAsync(x => x.Id == robotCategoryId, null);
            if (robotCategory != null)
            {
                return new DataResult<RobotCategoryDto>(ResultStatus.Success, new RobotCategoryDto
                {
                    RobotCategory = robotCategory,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotCategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IResult> Update(RobotCategoryUpdateDto robotCategoryUpdateDto)
        {
            var category = Mapper.Map<RobotCategory>(robotCategoryUpdateDto);
            await UnitOfWork.RobotCategory.UpdateAsync(category);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
