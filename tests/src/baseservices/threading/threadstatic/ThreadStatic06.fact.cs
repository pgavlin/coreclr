using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_ThreadStatic06_ThreadStatic06_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic06_ThreadStatic06_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic06\\ThreadStatic06.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
