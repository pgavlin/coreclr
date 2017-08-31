using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_tryfinallyincatchtry_d_tryfinallyincatchtry_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_tryfinallyincatchtry_d_tryfinallyincatchtry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\tryfinallyincatchtry_d\\tryfinallyincatchtry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
