using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartFloat_1_ThreadStartFloat_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartFloat_1_ThreadStartFloat_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartFloat_1\\ThreadStartFloat_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
