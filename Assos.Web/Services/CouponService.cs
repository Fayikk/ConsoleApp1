﻿using Assos.Web.Models;
using Assos.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assos.Web.Services
{
    public class CouponService : BaseService, ICouponService
    {

        private readonly IHttpClientFactory _clientFactory;

        public CouponService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetCoupon<T>(string couponCode, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + couponCode,
                AccessToken = token
            });
        }
    }
}
