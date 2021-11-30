using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wescale.DevTestCon.Tests {

	/// <summary>
	/// Tests für MathService
	/// </summary>
	[TestClass()]
	public class MathServiceTests {

		private MathService _mathService;

		[TestInitialize()]
		public void Initialize() {
			_mathService = new MathService();
		}

		/// <summary>
		/// Tests der Addition
		/// </summary>
		[TestMethod()]
		public void AddTest() {
			Assert.AreEqual(2, _mathService.Add(1, 1));
			Assert.AreEqual(3, _mathService.Add(1, 2));
			Assert.AreEqual(4, _mathService.Add(2, 2));
		}

		/// <summary>
		/// Tests der Subtraktion
		/// </summary>
		[TestMethod()]
		public void SubTest() {
			Assert.AreEqual(0, _mathService.Sub(1, 1));
			Assert.AreEqual(-1, _mathService.Sub(1, 2));
			Assert.AreEqual(0, _mathService.Sub(2, 2));
		}

		/// <summary>
		/// Tests der Multiplikation
		/// </summary>
		[TestMethod()]
		public void MulTest() {
			Assert.AreEqual(1, _mathService.Mul(1, 1));
			Assert.AreEqual(2, _mathService.Mul(1, 2));
			Assert.AreEqual(4, _mathService.Mul(2, 2));
		}

		/// <summary>
		/// Tests der Division
		/// </summary>
		[TestMethod()]
		public void DivTest() {
			Assert.AreEqual(1, _mathService.Div(1, 1));
			Assert.AreEqual(0, _mathService.Div(1, 2));
			Assert.AreEqual(1, _mathService.Div(2, 2));
		}

		/// <summary>
		/// Tests der Modulo-Operation
		/// </summary>
		[TestMethod()]
		public void ModSimpleTest() {
			Assert.AreEqual(0, _mathService.Mod(1, 1));
			Assert.AreEqual(1, _mathService.Mod(5, 2));
			Assert.AreEqual(0, _mathService.Mod(10, 2));
			Assert.AreEqual(2, _mathService.Mod(11, 3));
			Assert.AreEqual(0, _mathService.Mod(12, 3));
		}

		/// <summary>
		/// Weitere Tests der Modulo-Operation
		/// </summary>
		[TestMethod()]
		public void ModAdvancedTest() {
			Assert.AreEqual(0, _mathService.Mod(99, 9));
		}

	}
}