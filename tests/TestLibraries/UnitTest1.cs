using daborg69;
using Daborg69.Fax;
using NUnit.Framework;


namespace UnitTester
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}


		[Test]
		public void Test1()
		{
			Core core = new Core();
			Assert.NotZero(core.ValueA());
		}


		[Test]
		public void Test2 () {
			Core core = new Core();
			Assert.NotZero(core.ValueA());
			core.ResetA();
			Assert.AreEqual(0,core.ValueA());
		}


		[Test]
		public void Test3 () {
			Core core = new Core();
			//Assert.AreEqual(0,core.ValueX(),"A10:  X not correct value");
		}


		[Test]
		public void FaxTest () {
			Faxes fax = new Faxes(9);
			Assert.AreEqual(9, fax.NumberOfFaxes);

		}
	}
}