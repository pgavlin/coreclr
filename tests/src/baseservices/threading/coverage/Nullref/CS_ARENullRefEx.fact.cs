using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_ARENullRefEx_CS_ARENullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_ARENullRefEx_CS_ARENullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_ARENullRefEx\\CS_ARENullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
