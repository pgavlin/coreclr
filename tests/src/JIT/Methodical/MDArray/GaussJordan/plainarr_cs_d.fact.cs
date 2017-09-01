using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_GaussJordan_plainarr_cs_d_plainarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_GaussJordan_plainarr_cs_d_plainarr_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\plainarr_cs_d\\plainarr_cs_d.cmd");
        }
    }
}
