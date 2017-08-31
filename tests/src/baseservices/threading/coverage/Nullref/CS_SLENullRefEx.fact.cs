using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_SLENullRefEx_CS_SLENullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_SLENullRefEx_CS_SLENullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_SLENullRefEx\\CS_SLENullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
