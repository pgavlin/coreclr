using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_reversedtryblock_r_reversedtryblock_r_
    {
        [Fact]
        public void _eh_disconnected_reversedtryblock_r_reversedtryblock_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\reversedtryblock_r\\reversedtryblock_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
