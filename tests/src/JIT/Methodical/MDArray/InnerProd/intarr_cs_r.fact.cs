using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_intarr_cs_r_intarr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_intarr_cs_r_intarr_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\intarr_cs_r\\intarr_cs_r.cmd");
        }
    }
}
