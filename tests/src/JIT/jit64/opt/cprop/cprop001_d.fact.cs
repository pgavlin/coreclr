using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cprop_cprop001_d_cprop001_d_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_d_cprop001_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_d\\cprop001_d.cmd");
        }
    }
}
