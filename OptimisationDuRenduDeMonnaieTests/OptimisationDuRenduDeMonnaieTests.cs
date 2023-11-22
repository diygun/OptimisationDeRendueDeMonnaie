using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationDeRendueDeMonnaie;

namespace OptimisationDuRenduDeMonnaieTests
{
    [TestClass]
    public class OptimisationDuRenduDeMonnaieTests
    {
        private OptimisationDuRenduDeMonnaie _rdm {  get; set; } = null!;

        [TestMethod]
        public void GetOptimisationDuRenduDeMonnaie_10()
        {
            int billet = 10;

            var result = _rdm.FirstFcnt(billet);

            Assert.AreEqual("10", result);


        }

    }
}
