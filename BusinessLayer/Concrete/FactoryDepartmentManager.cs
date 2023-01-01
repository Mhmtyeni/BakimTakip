using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FactoryDepartmentDtos;
using EntityLayer.Utilities.Results.Abstract;
using EntityLayer.Utilities.Results.ComplexTypes;
using EntityLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FactoryDepartmentManager : ManagerBase, IFactoryDepartmentService
    {
        public FactoryDepartmentManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(FactoryDepartmentAddDto factoryDepartmentAddDto)
        {
            var factoryDepartment = Mapper.Map<FactoryDepartment>(factoryDepartmentAddDto);
            await UnitOfWork.FactoryDepartment.AddAsync(factoryDepartment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int factoryDepartmentId)
        {
            var result = await UnitOfWork.FactoryDepartment.AnyAsync(a => a.Id == factoryDepartmentId);
            if (result)
            {
                var factoryDepartment = await UnitOfWork.FactoryDepartment.GetAsync(a => a.Id == factoryDepartmentId);
                factoryDepartment.IsActive = false;
                factoryDepartment.IsDeleted = true;
                await UnitOfWork.FactoryDepartment.UpdateAsync(factoryDepartment);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir bölüm bulunamadı.");
        }

        public async Task<IDataResult<FactoryDepartmentListDto>> GetAll()
        {
            var factoryDepartments = await UnitOfWork.FactoryDepartment.GetAllAsync(x => x.IsActive == true && x.IsDeleted == false,x => x.Factory);
            if (factoryDepartments != null)
            {
                return new DataResult<FactoryDepartmentListDto>(ResultStatus.Success, new FactoryDepartmentListDto
                {
                    FactoryDepartments = factoryDepartments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FactoryDepartmentListDto>(ResultStatus.Error, "Böyle bir bölüm bulunamadı.", null);
        }

        public async Task<IDataResult<FactoryDepartmentListDto>> GetByFactoryId(int factoryId)
        {
            var factoryDepartment = await UnitOfWork.FactoryDepartment.GetAllAsync(x => x.FactoryId == factoryId && x.IsActive == true && x.IsDeleted == false, null);
            if (factoryDepartment != null)
            {
                return new DataResult<FactoryDepartmentListDto>(ResultStatus.Success, new FactoryDepartmentListDto
                {
                    FactoryDepartments = factoryDepartment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FactoryDepartmentListDto>(ResultStatus.Error, "Böyle bir bölüm bulunamadı.", null);
        }

        public async Task<IDataResult<FactoryDepartmentDto>> GetById(int factoryDepartmentId)
        {
            var factoryDepartment = await UnitOfWork.FactoryDepartment.GetAsync(x => x.Id == factoryDepartmentId);
            if (factoryDepartment != null)
            {
                return new DataResult<FactoryDepartmentDto>(ResultStatus.Success, new FactoryDepartmentDto
                {
                    FactoryDepartment = factoryDepartment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<FactoryDepartmentDto>(ResultStatus.Error, "Böyle bir bölüm bulunamadı.", null);
        }

        public async Task<IResult> Update(FactoryDepartmentUpdateDto factoryDepartmentUpdateDto)
        {
            var factoryDepartment = Mapper.Map<FactoryDepartment>(factoryDepartmentUpdateDto);
            await UnitOfWork.FactoryDepartment.UpdateAsync(factoryDepartment);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
