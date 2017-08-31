using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartFloat_ThreadStartFloat_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartFloat_ThreadStartFloat_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartFloat\\ThreadStartFloat.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
