using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cprop_cprop001_r_cprop001_r_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_r_cprop001_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_r\\cprop001_r.cmd");
        }
    }
}
