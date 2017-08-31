using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_timeoutexception_TimeoutExceptionCtor1_TimeoutExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_timeoutexception_TimeoutExceptionCtor1_TimeoutExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\timeoutexception\\TimeoutExceptionCtor1\\TimeoutExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
