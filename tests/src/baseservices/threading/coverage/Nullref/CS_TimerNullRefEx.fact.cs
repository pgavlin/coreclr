using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _coverage_Nullref_CS_TimerNullRefEx_CS_TimerNullRefEx_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_Nullref_CS_TimerNullRefEx_CS_TimerNullRefEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\coverage\\Nullref\\CS_TimerNullRefEx\\CS_TimerNullRefEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
