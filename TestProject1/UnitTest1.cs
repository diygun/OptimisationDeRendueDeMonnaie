using NUnit.Framework;
using OptimisationDeRendueDeMonnaie;

namespace TestProject1
{
    public class Tests
    {
        private OptimisationDuRenduDeMonnaie _rdm { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _rdm = new OptimisationDuRenduDeMonnaie();
        }
        [Test]
        public void TestRendueDeMonnaie_8()
        {
            int Amount = 8;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("4 * 2", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_9()
        {
            int Amount = 9;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("2 * 2 + 1 * 5", Result);
        }

        [Test]
        public void TestRendueDeMonnaie_10()
        {
            int Amount = 10;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("1 * 10", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_11()
        {
            int Amount = 11;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("3 * 2 + 1 * 5", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_21()
        {
            int Amount = 21;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("3 * 2 + 1 * 5 + 1 * 10", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_20()
        {
            int Amount = 20;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("2 * 10", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_23()
        {
            int Amount = 23;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("4 * 2 + 1 * 5 + 1 * 10", Result);
        }
        [Test]
        public void TestRendueDeMonnaie_31()
        {
            int Amount = 31;

            var Result = _rdm.BankNotes(Amount);

            Assert.AreEqual("3 * 2 + 1 * 5 + 2 * 10", Result);
        }

        [Test]
        public void TestRendueDeMonnaie_9007199254740991()
        {
            long Amount = 9007199254740991;

            var Result = _rdm.BankNotes(Amount);
            //10 * 900 719 925 474 098 + 5 + 2 * 3
            Assert.AreEqual("3 * 2 + 1 * 5 + 900719925474098 * 10", Result);
        }
    }
}