using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_RWHNullRefEx_CS_RWHNullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_RWHNullRefEx_CS_RWHNullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_RWHNullRefEx\\CS_RWHNullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
