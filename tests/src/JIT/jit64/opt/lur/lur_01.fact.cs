using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_lur_lur_01_lur_01_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lur_lur_01_lur_01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lur\\lur_01\\lur_01.cmd");
        }
    }
}
