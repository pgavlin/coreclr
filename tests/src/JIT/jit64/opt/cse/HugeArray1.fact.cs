using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_HugeArray1_HugeArray1_
    {
        [Fact]
        public void _opt_cse_HugeArray1_HugeArray1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeArray1\\HugeArray1.cmd");
        }
    }
}
