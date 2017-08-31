using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDecimal_ThreadStartDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDecimal_ThreadStartDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDecimal\\ThreadStartDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
