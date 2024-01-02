

using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountantManagementApp.DAL.Interfaces;
using AccountantManagementApp.DAL.Services;
using Xunit;
using Xunit.Abstractions;

namespace AccountantManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IAccountantService _accountantService;
        public readonly Mock<IAccountantRepository> accountantservice = new Mock<IAccountantRepository>();

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _accountantService = new AccountantService(accountantservice.Object);
            _output = output;
        }

        [Fact]
        public async Task<bool> Testfor_GetAll_Accountants_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                accountantservice.Setup(repos => repos.GetAll()).Returns("");
                var result = _accountantService.GetAll();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Update_Accountants_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                accountantservice.Setup(repos => repos.Update()).Returns("");
                var result = _accountantService.Update();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


    }
}