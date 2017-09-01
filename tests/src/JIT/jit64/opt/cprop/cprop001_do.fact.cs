using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cprop_cprop001_do_cprop001_do_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_do_cprop001_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_do\\cprop001_do.cmd");
        }
    }
}
