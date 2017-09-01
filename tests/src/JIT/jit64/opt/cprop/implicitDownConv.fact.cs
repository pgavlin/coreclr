using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cprop_implicitDownConv_implicitDownConv_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_implicitDownConv_implicitDownConv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\implicitDownConv\\implicitDownConv.cmd");
        }
    }
}
