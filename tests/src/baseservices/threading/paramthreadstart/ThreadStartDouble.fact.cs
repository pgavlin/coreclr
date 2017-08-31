using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDouble_ThreadStartDouble_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDouble_ThreadStartDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDouble\\ThreadStartDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
