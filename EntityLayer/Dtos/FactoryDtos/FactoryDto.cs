using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Dtos.FactoryDtos
{
    public class FactoryDto:DtoGetBase
    {
        public Factory Factory { get; set; }
    }
}
