using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timeoutexception_TimeoutExceptionCtor2_TimeoutExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_timeoutexception_TimeoutExceptionCtor2_TimeoutExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timeoutexception\\TimeoutExceptionCtor2\\TimeoutExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
