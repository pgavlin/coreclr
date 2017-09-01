using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_GaussJordan_structarr_cs_r_structarr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_GaussJordan_structarr_cs_r_structarr_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\structarr_cs_r\\structarr_cs_r.cmd");
        }
    }
}
