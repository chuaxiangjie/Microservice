using MediatorandCQRS.RequestModels.CommandRequestModels;
using MediatorandCQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorandCQRS.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);

    }
}
