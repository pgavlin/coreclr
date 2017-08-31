using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartCast_1_ThreadStartCast_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartCast_1_ThreadStartCast_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartCast_1\\ThreadStartCast_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
