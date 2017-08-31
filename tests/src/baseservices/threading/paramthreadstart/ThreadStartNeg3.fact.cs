using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartNeg3_ThreadStartNeg3_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNeg3_ThreadStartNeg3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNeg3\\ThreadStartNeg3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
