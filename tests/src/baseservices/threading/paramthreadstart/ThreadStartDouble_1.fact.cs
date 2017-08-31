using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDouble_1_ThreadStartDouble_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDouble_1_ThreadStartDouble_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDouble_1\\ThreadStartDouble_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
