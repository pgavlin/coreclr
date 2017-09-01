using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_r8div_cs_d_r8div_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r8div_cs_d_r8div_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r8div_cs_d\\r8div_cs_d.cmd");
        }
    }
}
