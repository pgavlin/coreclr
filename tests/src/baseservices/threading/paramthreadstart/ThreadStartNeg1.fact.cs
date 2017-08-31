using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartNeg1_ThreadStartNeg1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNeg1_ThreadStartNeg1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNeg1\\ThreadStartNeg1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
