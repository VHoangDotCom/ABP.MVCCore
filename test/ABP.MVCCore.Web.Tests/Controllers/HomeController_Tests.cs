﻿using System.Threading.Tasks;
using ABP.MVCCore.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABP.MVCCore.Web.Tests.Controllers
{
    public class HomeController_Tests: MVCCoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
