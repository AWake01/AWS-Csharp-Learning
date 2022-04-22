using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans.Test
{
    [ProductComparison]
    public class ProductComparerShould
    {
        private List<LoanProduct> products;
        private ProductComparer sut;

        [OneTimeSetUp]
        public void OneTimeSetup()  //Runs before first test
        {
            products = new List<LoanProduct>
            {
                new LoanProduct(1, "a", 1),
                new LoanProduct(2, "b", 2),
                new LoanProduct(3, "c", 3),
            };
        }

        [SetUp]
        public void setup() //Runs before each test
        {
            sut = new ProductComparer(new LoanAmount("USD", 200_000m), products);
        }

        [TearDown]
        public void TearDown()  //Runs after each test
        {
            //sut.Dispose();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()  //Runs after last test
        {
            //sut.Dispose();
        }


        [Test]
        public void ReturnCorrectNumberOfConparisons()
        {        
            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            Assert.That(comparisons, Has.Exactly(3).Items);
        }

        [Test]
        public void NotRetrurnDuplicateComparions()
        {
            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            Assert.That(comparisons, Is.Unique);
        }

        [Test]
        public void ReturnComparisonForFirstProduct()
        {
            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            var expectedProduct = new MonthlyRepaymentComparison("a", 1, 643.28m);

            Assert.That(comparisons, Does.Contain(expectedProduct));
        }

        [Test]
        public void ReturnComparisonForFirstProductWithPartialKnownExpectedValues()
        {
            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            //Don't care about the expectd montly reypayment, only that the product is there

            //Assert.That(comparisons, Has.Exactly(1).Property("ProductName").EqualTo("a").And.Property("InterestRate").EqualTo(1).And.Property("MonthlyRepayment").GreaterThan(0));

            //Assert.That(comparisons, Has.Exactly(1).Matches<MonthlyRepaymentComparison>(item => item.ProductName == "a" &&
            //item.InterestRate == 1 && 
            //item.MonthlyRepayment > 0));
            //Using custom assert
            Assert.That(comparisons, Has.Exactly(1).Matches(new MonthlyRepaymentGreaterThanZeroConstraint("a", 1)));
        }
    }
}
