using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorandCQRS.ResponseModels.CommandResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSuccess { get; set; }

        public string OrderId { get; set; }

    }
}
