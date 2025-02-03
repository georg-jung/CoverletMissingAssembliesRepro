namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var uut = new CoverletMissingAssembliesRepro.Test();
            Assert.Equal("42", uut.GetTheAnswer());
        }
    }
}
