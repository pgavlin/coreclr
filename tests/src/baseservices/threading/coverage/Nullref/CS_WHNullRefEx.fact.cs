using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_WHNullRefEx_CS_WHNullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_WHNullRefEx_CS_WHNullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_WHNullRefEx\\CS_WHNullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
