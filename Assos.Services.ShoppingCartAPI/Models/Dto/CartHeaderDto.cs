﻿using System.ComponentModel.DataAnnotations;

namespace Assos.Services.ShoppingCartAPI.Models.Dto
{
    public class CartHeaderDto
    {

        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}
