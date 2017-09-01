using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_r8div_cs_r_r8div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r8div_cs_r_r8div_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r8div_cs_r\\r8div_cs_r.cmd");
        }
    }
}
