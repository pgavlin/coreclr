using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartCast_2_ThreadStartCast_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartCast_2_ThreadStartCast_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartCast_2\\ThreadStartCast_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
