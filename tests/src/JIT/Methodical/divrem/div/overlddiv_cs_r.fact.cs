using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_overlddiv_cs_r_overlddiv_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_r_overlddiv_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_r\\overlddiv_cs_r.cmd");
        }
    }
}
