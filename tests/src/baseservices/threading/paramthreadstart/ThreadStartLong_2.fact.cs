using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartLong_2_ThreadStartLong_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartLong_2_ThreadStartLong_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartLong_2\\ThreadStartLong_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
