using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_HugeField1_HugeField1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeField1_HugeField1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeField1\\HugeField1.cmd");
        }
    }
}
