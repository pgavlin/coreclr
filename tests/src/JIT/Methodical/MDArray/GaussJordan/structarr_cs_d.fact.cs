using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_GaussJordan_structarr_cs_d_structarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_GaussJordan_structarr_cs_d_structarr_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\structarr_cs_d\\structarr_cs_d.cmd");
        }
    }
}
