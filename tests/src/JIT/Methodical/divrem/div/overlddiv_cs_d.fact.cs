using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_overlddiv_cs_d_overlddiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_d_overlddiv_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_d\\overlddiv_cs_d.cmd");
        }
    }
}
