using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_reversedtryblock_d_reversedtryblock_d_
    {
        [Fact]
        public void _eh_disconnected_reversedtryblock_d_reversedtryblock_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\reversedtryblock_d\\reversedtryblock_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
