using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartULong_1_ThreadStartULong_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartULong_1_ThreadStartULong_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartULong_1\\ThreadStartULong_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
