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
            int montant = 8;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("4 * 2", result);
        }
        [Test]
        public void TestRendueDeMonnaie_9()
        {
            int montant = 9;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("2 * 2 + 1 * 5", result);
        }

        [Test]
        public void TestRendueDeMonnaie_10()
        {
            int montant = 10;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("1 * 10", result);
        }
        [Test]
        public void TestRendueDeMonnaie_11()
        {
            int montant = 11;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("3 * 2 + 1 * 5", result);
        }
        [Test]
        public void TestRendueDeMonnaie_21()
        {
            int montant = 21;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("3 * 2 + 1 * 5 + 1 * 10", result);
        }
        [Test]
        public void TestRendueDeMonnaie_20()
        {
            int montant = 20;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("2 * 10", result);
        }
        [Test]
        public void TestRendueDeMonnaie_23()
        {
            int montant = 23;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("4 * 2 + 1 * 5 + 1 * 10", result);
        }
        [Test]
        public void TestRendueDeMonnaie_31()
        {
            int montant = 31;

            var result = _rdm.BankNotes(montant);

            Assert.AreEqual("3 * 2 + 1 * 5 + 2 * 10", result);
        }

        [Test]
        public void TestRendueDeMonnaie_9007199254740991()
        {
            long montant = 9007199254740991;

            var result = _rdm.BankNotes(montant);
            //10 * 900 719 925 474 098 + 5 + 2 * 3
            Assert.AreEqual("3 * 2 + 1 * 5 + 900719925474098 * 10", result);
        }
    }
}