using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartCast_ThreadStartCast_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartCast_ThreadStartCast_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartCast\\ThreadStartCast.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
