using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_ThreadStatic02_ThreadStatic02_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic02_ThreadStatic02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic02\\ThreadStatic02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
