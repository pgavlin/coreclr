using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_GaussJordan_plainarr_cs_r_plainarr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_GaussJordan_plainarr_cs_r_plainarr_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\plainarr_cs_r\\plainarr_cs_r.cmd");
        }
    }
}
