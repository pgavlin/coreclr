using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartULong_ThreadStartULong_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartULong_ThreadStartULong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartULong\\ThreadStartULong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
