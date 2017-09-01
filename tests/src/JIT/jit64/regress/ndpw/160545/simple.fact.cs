using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ndpw_160545_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ndpw_160545_simple_simple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ndpw\\160545\\simple\\simple.cmd");
        }
    }
}
