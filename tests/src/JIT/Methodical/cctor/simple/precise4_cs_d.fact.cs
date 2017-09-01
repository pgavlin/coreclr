using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise4_cs_d_precise4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise4_cs_d_precise4_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise4_cs_d\\precise4_cs_d.cmd");
        }
    }
}
