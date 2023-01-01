using EntityLayer.Dtos.FaultReportDtos;
using EntityLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFaultReportService
    {
        public Task<IResult> Add(FaultReportAddDto faultReportAddDto);
        public Task<IResult> Update(FaultReportUpdateDto faultReportUpdateDto);
        public Task<IResult> DeleteById(int faultReportId);
        public Task<IDataResult<FaultReportListDto>> GetAll();
        public Task<IDataResult<FaultReportListDto>> GetByFactory(int factoryId, int factoryId2, int factoryId3, int factoryId4);
        public Task<IDataResult<FaultReportDto>> GetById(int faultReportId);
        public Task<IDataResult<FaultReportDto>> GetByNote(string faultReportNote);
    }
}
