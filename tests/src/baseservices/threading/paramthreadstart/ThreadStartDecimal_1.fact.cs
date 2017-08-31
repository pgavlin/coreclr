using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDecimal_1_ThreadStartDecimal_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDecimal_1_ThreadStartDecimal_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDecimal_1\\ThreadStartDecimal_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
