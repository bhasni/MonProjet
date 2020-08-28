using System;
using Exercice.Repositories;
using Exercice.Services;
using Exercice.Services.Implementations;
using Moq;
using Xunit;

namespace Exercice.Tests.Services
{
    public class BankAccountServiceTests
    {
        private readonly IBankAccountService _bankAccountService;
        private readonly Mock<IBankAccountRepository> _bankAccountRepositoryMock;

        public BankAccountServiceTests()
        {
            _bankAccountRepositoryMock = new Mock<IBankAccountRepository>();
            _bankAccountService = new BankAccountService(_bankAccountRepositoryMock.Object);
        }

        [Fact]
        public async void CanCreateOperation()
        {
            //Test Data
            var clientId = 10;
            var amount = 500;
            var operationType = "Deposit";

            var expectedCreatedOperation = 1;

            #region Mocks Configuration

            _bankAccountRepositoryMock.Setup(c => c.CreateOperation(clientId, amount, operationType)).ReturnsAsync(expectedCreatedOperation);

            #endregion


            var createdOperation = await _bankAccountService.CreateOperation(clientId, amount, operationType);
            Assert.Equal(createdOperation, expectedCreatedOperation);


            #region Mocks Verification

            _bankAccountRepositoryMock.Verify(c => c.CreateOperation(clientId, amount, operationType), Times.Once);

            #endregion
        }

        [Fact]
        public async void CantCreateOperationClientNotFound()
        {
            //Test Data
            var clientId = 10;
            var amount = 500;
            var operationType = "Deposit";

            #region Mocks Configuration

            _bankAccountRepositoryMock.Setup(c => c.CreateOperation(clientId, amount, operationType)).ThrowsAsync(new Exception());

            #endregion

           var result =  await Assert.ThrowsAsync<Exception>(() =>
               _bankAccountService.CreateOperation(clientId, amount, operationType));

           Assert.NotEmpty(result.Message);


            #region Mocks Verification

            _bankAccountRepositoryMock.Verify(c => c.CreateOperation(clientId, amount, operationType), Times.Once);

            #endregion
        }
    }
}
