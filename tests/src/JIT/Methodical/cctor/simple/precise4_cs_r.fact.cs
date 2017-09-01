using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise4_cs_r_precise4_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise4_cs_r_precise4_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise4_cs_r\\precise4_cs_r.cmd");
        }
    }
}
