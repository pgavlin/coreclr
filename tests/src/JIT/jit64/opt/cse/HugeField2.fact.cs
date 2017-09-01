using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_HugeField2_HugeField2_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeField2_HugeField2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeField2\\HugeField2.cmd");
        }
    }
}
