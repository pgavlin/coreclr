using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartULong_2_ThreadStartULong_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartULong_2_ThreadStartULong_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartULong_2\\ThreadStartULong_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
