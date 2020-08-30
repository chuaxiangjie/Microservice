using MediatorandCQRS.RequestModels;
using MediatorandCQRS.RequestModels.QueryRequestModels;
using MediatorandCQRS.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorandCQRS.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {

        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);

    }
}
