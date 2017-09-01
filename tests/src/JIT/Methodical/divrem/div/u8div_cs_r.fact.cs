using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_u8div_cs_r_u8div_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_u8div_cs_r_u8div_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\u8div_cs_r\\u8div_cs_r.cmd");
        }
    }
}
