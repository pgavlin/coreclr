using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartLong_1_ThreadStartLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartLong_1_ThreadStartLong_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartLong_1\\ThreadStartLong_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
