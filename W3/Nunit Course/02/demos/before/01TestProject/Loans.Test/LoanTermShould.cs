using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans.Test
{
    public class LoanTermShould
    {
        [Test][Ignore("Need to complete update work")]
        public void ReturnTermInMonths()
        {
            var sut = new LoanTerm(1);

            Assert.That(sut.ToMonths(), Is.EqualTo(12), "Months should be 12 x number of years");    //Constraint model:  Assert.That(test result, constraint instance)
                                                            //Classic model:  Assert.AreEqual(n, test result)
        }
        
        [Test]
        public void StoreYears()
        {
            var sut = new LoanTerm(1);

            Assert.That(sut.Years, Is.EqualTo(1));
        }

        [Test]
        public void RespectValueEquality()
        {
            var a = new LoanTerm(1);
            var b = new LoanTerm(1);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void RespectValueInequality()
        {
            var a = new LoanTerm(1);
            var b = new LoanTerm(2);

            Assert.That(a, Is.Not.EqualTo(b));
        }

        [Test]
        [Obsolete]
        public void ReferenceEqualityExample()
        {
            var a = new LoanTerm(1);
            var b = a;
            var c = new LoanTerm(1);

            Assert.That(a, Is.SameAs(b));       
            Assert.That(a, Is.Not.SameAs(c));   //.SameAs does not compare the content, only the object reference

            var x = new List<string> { "a", "b"};
            var y = x;
            var z = new List<string> { "a", "b" };

            Assert.That(y, Is.SameAs(x));
            Assert.That(z, Is.Not.SameAs(x));   //.SameAs does not compare the content, only the object reference
        }

        [Test]
        public void Double()
        {
            double a = 1.0 / 3.0;

            Assert.That(a, Is.EqualTo(0.33).Within(0.004));         //.Within() allows for tolerancea to be set
            Assert.That(a, Is.EqualTo(0.33).Within(10).Percent);    //.Within().percent gives a percantage tolerance
        }

        [Test]
        public void NotAllowZeroYears()
        {
           Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>());

           Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                            .With
                            .Property("Message")
                            .EqualTo("Please specify a value greater than 0. (Parameter 'years')"));

           Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                            .With
                            .Message
                            .EqualTo("Please specify a value greater than 0. (Parameter 'years')"));

           //Correct ex and param name but don't care about the message
           Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                            .With
                            .Property("ParamName")
                            .EqualTo("years"));

           Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                             .With
                             .Matches<ArgumentOutOfRangeException>(
                                 ex => ex.ParamName == "years"));
        }


        [Test]
        //[TestCase(200_000, 6.5, 30, 1264.14)]
        public void CalulateCorrectMonthlyRepayment(decimal pricipal, decimal interestRate, int termInYears, decimal expectedMonthlyPayment)
        {
            var sut = new LoanRepaymentCalculator();

            var monthlyPayment = sut.CalculateMonthlyRepayment(
                                     new LoanAmount("USD", pricipal), interestRate, new LoanTerm(termInYears));

            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));
        }
    }
}
