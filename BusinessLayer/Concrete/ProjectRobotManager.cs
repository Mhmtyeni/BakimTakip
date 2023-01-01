using AutoMapper;
using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProjectRobotDtos;
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
    public class ProjectRobotManager : ManagerBase, IProjectRobotService
    {
        public ProjectRobotManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IResult> Add(ProjectRobotAddDto projectRobotAddDto)
        {
            var projectRobot = Mapper.Map<ProjectRobot>(projectRobotAddDto);
            await UnitOfWork.ProjectRobot.AddAsync(projectRobot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteById(int projectRobotId)
        {
            var result = await UnitOfWork.ProjectRobot.AnyAsync(a => a.Id == projectRobotId);
            if (result)
            {
                var projectRobot = await UnitOfWork.ProjectRobot.GetAsync(a => a.Id == projectRobotId);
                projectRobot.IsActive = false;
                projectRobot.IsDeleted = true;
                await UnitOfWork.ProjectRobot.UpdateAsync(projectRobot);
                await UnitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir robot bulunamadı.");
        }

        public async Task<IDataResult<ProjectRobotListDto>> GetAll()
        {
            IQueryable<ProjectRobot> query = UnitOfWork.ProjectRobot.GetAsQueryable();
            query = query.Where(x => x.IsActive == true && x.IsDeleted == false).
                Include(x => x.Project).
                Include(x => x.Robot);
            var projectRobots = await query.ToListAsync();
            if (projectRobots != null)
            {
                return new DataResult<ProjectRobotListDto>(ResultStatus.Success, new ProjectRobotListDto
                {
                    ProjectRobots = projectRobots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectRobotListDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectRobotDto>> GetById(int projectRobotId)
        {
            var projectRobot = await UnitOfWork.ProjectRobot.GetAsync(x => x.Id == projectRobotId);
            if (projectRobot != null)
            {
                return new DataResult<ProjectRobotDto>(ResultStatus.Success, new ProjectRobotDto
                {
                    ProjectRobot = projectRobot,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectRobotDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectRobotListDto>> GetByProjectId(int projectId)
        {
            IQueryable<ProjectRobot> query = UnitOfWork.ProjectRobot.GetAsQueryable();
            query = query.Where(x => x.ProjectId == projectId && x.IsActive == true && x.IsDeleted == false);
            var projectRobots = await query.ToListAsync();
            if (projectRobots != null)
            {
                return new DataResult<ProjectRobotListDto>(ResultStatus.Success, new ProjectRobotListDto
                {
                    ProjectRobots = projectRobots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectRobotListDto>(ResultStatus.Error, "Böyle bir proje bulunamadı.", null);
        }

        public async Task<IDataResult<ProjectRobotListDto>> GetByRobotId(int robotId)
        {
            IQueryable<ProjectRobot> query = UnitOfWork.ProjectRobot.GetAsQueryable();
            query = query.Where(x => x.RobotId == robotId && x.IsActive == true && x.IsDeleted == false);
            var projectRobots = await query.ToListAsync();
            if (projectRobots != null)
            {
                return new DataResult<ProjectRobotListDto>(ResultStatus.Success, new ProjectRobotListDto
                {
                    ProjectRobots = projectRobots,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProjectRobotListDto>(ResultStatus.Error, "Böyle bir robot bulunamadı.", null);
        }

        public async Task<IResult> Update(ProjectRobotUpdateDto projectRobotUpdateDto)
        {
            var projectRobot = Mapper.Map<ProjectRobot>(projectRobotUpdateDto);
            await UnitOfWork.ProjectRobot.UpdateAsync(projectRobot);
            await UnitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, "Başarıyla güncellenmiştir.");
        }
    }
}
