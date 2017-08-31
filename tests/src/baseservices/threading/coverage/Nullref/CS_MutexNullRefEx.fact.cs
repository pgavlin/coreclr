using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_MutexNullRefEx_CS_MutexNullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_MutexNullRefEx_CS_MutexNullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_MutexNullRefEx\\CS_MutexNullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
