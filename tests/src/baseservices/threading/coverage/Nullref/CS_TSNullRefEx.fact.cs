using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_TSNullRefEx_CS_TSNullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_TSNullRefEx_CS_TSNullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_TSNullRefEx\\CS_TSNullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
