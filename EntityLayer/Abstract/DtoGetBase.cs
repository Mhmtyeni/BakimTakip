using EntityLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
