using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_volatilefield_volatilefield_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_volatilefield_volatilefield_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\volatilefield\\volatilefield.cmd");
        }
    }
}
