using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.FaultReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper.Profiles
{
    public class FaultReportProfile : Profile
    {
        public FaultReportProfile()
        {
            CreateMap<FaultReportAddDto, FaultReport>();
            CreateMap<FaultReportUpdateDto, FaultReport>();
        }
    }
}
