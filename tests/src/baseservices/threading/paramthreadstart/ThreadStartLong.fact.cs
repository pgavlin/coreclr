using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartLong_ThreadStartLong_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartLong_ThreadStartLong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartLong\\ThreadStartLong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
