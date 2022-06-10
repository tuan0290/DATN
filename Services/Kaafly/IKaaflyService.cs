﻿using Entities.Common;
using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Kaafly
{
    public interface IKaaflyService
    {
        PaginationModel<List<ProductViewModel>> GetListProductByCategoryId(RequestHomeViewModel request);
        ProductCategory GetCategoryById(int id);
        ProductViewModel GetProductById(int id);
        List<ProductViewModel> GetListProductByHomeHot(bool isHome, bool isHot, int count);
        OrderResponseViewModel OrderRequest(OrderRequestViewModel model);
        TrackingOrderReceivedModel GetOrderReceivedByOrderCode(string orderCode);
        List<OrderReceivedViewModel> ListOrderReceivedOfMemberByPhoneNumber(string phoneNumber);
    }
}
