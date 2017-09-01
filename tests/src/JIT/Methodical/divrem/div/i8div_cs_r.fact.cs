using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_i8div_cs_r_i8div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_i8div_cs_r_i8div_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\i8div_cs_r\\i8div_cs_r.cmd");
        }
    }
}
