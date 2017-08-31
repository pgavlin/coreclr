using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartNeg4_ThreadStartNeg4_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNeg4_ThreadStartNeg4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNeg4\\ThreadStartNeg4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
