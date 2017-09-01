using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_overlddiv_cs_ro_overlddiv_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_ro_overlddiv_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_ro\\overlddiv_cs_ro.cmd");
        }
    }
}
