using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_lur_lur_02_lur_02_
    {
        [OuterLoop]
        [Fact]
        public void _opt_lur_lur_02_lur_02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\lur\\lur_02\\lur_02.cmd");
        }
    }
}
