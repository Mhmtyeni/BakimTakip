using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.RobotDtos;
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
    public class RobotManager : ManagerBase, IRobotService
    {
        public RobotManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(RobotAddDto robotAddDto)
        {
            var robot = Mapper.Map<Robot>(robotAddDto);
            await UnitOfWork.Robot.AddAsync(robot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int robotId)
        {
            var result = await UnitOfWork.Robot.AnyAsync(a => a.Id == robotId);
            if (result)
            {
                var robot = await UnitOfWork.Robot.GetAsync(a => a.Id == robotId);
                robot.IsActive = false;
                robot.IsDeleted = true;
                await UnitOfWork.Robot.UpdateAsync(robot);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir robot bulunamadı.");
        }

        public async Task<IDataResult<RobotListDto>> GetAll()
        {
            IQueryable<Robot> query = UnitOfWork.Robot.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.RobotCategory);
            var robots = await query.ToListAsync();
            if (robots != null)
            {
                return new DataResult<RobotListDto>(ResultStatus.Success, new RobotListDto
                {
                    Robots = robots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotListDto>(ResultStatus.Error, "Bakımı tanımlanmış ekipman bulunamadı.", null);
        }

        public async Task<IDataResult<RobotDto>> GetById(int robotId)
        {
            var robot = await UnitOfWork.Robot.GetAsync(x => x.Id == robotId);
            if (robot != null)
            {
                return new DataResult<RobotDto>(ResultStatus.Success, new RobotDto
                {
                    Robot = robot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }

        public async Task<IDataResult<RobotListDto>> GetByRobotCategoryId(int robotCategoryId)
        {
            IQueryable<Robot> query = UnitOfWork.Robot.GetAsQueryable();
            query = query.Where(x => x.RobotCategoryId == robotCategoryId && x.IsActive == true && x.IsDeleted == false);
            var robots = await query.ToListAsync();
            if (robots != null)
            {
                return new DataResult<RobotListDto>(ResultStatus.Success, new RobotListDto
                {
                    Robots = robots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotListDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }

        public async Task<IResult> Update(RobotUpdateDto robotUpdateDto)
        {
            var robot = Mapper.Map<Robot>(robotUpdateDto);
            await UnitOfWork.Robot.UpdateAsync(robot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
        public async Task<bool> CheckNameExist(string name)
        {
            return await UnitOfWork.Robot.AnyAsync(x => x.Name == name);
        }
        public async Task<IDataResult<RobotListDto>> SearchByKeyword(string keyword)
        {
            string normalizedKeyword = "";
            if (keyword != "")
                normalizedKeyword = keyword.ToLower();
            var query = UnitOfWork.Robot.GetAsQueryable();
            query = query.Where(
            x => x.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.Note.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false ||
            x.RobotCategory.Name.ToLower().Contains(normalizedKeyword) && x.IsActive == true && x.IsDeleted == false )
                .Include(x => x.RobotCategory)
                .OrderByDescending(x => x.CreatedDate);
            var robots = await query.ToListAsync();
            if (robots != null)
            {
                return new DataResult<RobotListDto>(ResultStatus.Success, new RobotListDto
                {
                    Robots = robots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<RobotListDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }
    }
}
