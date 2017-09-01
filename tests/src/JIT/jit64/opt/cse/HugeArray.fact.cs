using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_HugeArray_HugeArray_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeArray_HugeArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeArray\\HugeArray.cmd");
        }
    }
}
