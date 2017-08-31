using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartDecimal_2_ThreadStartDecimal_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDecimal_2_ThreadStartDecimal_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDecimal_2\\ThreadStartDecimal_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
