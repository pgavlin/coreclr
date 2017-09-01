using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_overlddiv_cs_do_overlddiv_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_overlddiv_cs_do_overlddiv_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\overlddiv_cs_do\\overlddiv_cs_do.cmd");
        }
    }
}
