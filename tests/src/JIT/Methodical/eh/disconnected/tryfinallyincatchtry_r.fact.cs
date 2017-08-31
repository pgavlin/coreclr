using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_disconnected_tryfinallyincatchtry_r_tryfinallyincatchtry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_disconnected_tryfinallyincatchtry_r_tryfinallyincatchtry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\disconnected\\tryfinallyincatchtry_r\\tryfinallyincatchtry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
