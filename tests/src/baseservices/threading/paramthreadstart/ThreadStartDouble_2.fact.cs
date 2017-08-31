using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDouble_2_ThreadStartDouble_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDouble_2_ThreadStartDouble_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDouble_2\\ThreadStartDouble_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
