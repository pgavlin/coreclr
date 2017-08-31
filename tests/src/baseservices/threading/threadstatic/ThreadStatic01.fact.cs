using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_ThreadStatic01_ThreadStatic01_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic01_ThreadStatic01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic01\\ThreadStatic01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
