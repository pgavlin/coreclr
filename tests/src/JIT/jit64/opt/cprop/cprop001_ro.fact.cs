using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_cprop_cprop001_ro_cprop001_ro_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cprop_cprop001_ro_cprop001_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cprop\\cprop001_ro\\cprop001_ro.cmd");
        }
    }
}
