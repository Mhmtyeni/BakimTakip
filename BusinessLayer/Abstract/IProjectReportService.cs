using EntityLayer.Dtos.ProjectReportDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectReportService
    {
        public Task<IResult> Add(ProjectReportAddDto projectReportAddDto);
        public Task<IResult> Update(ProjectReportUpdateDto projectReportUpdateDto);
        public Task<IResult> DeleteById(int projectReportId);
        public Task<IDataResult<ProjectReportListDto>> GetAll();
        public Task<IDataResult<ProjectReportListDto>> GetByFactory(int factoryId, int factoryId2, int factoryId3, int factoryId4);
        public Task<IDataResult<ProjectReportDto>> GetById(int projectReportId);
        public Task<IDataResult<ProjectReportDto>> GetByNote(string projectReportNote);
    }
}
