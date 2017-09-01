using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cse_volatilestaticfield_volatilestaticfield_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_volatilestaticfield_volatilestaticfield_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\volatilestaticfield\\volatilestaticfield.cmd");
        }
    }
}
