using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartFloat_2_ThreadStartFloat_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartFloat_2_ThreadStartFloat_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartFloat_2\\ThreadStartFloat_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
