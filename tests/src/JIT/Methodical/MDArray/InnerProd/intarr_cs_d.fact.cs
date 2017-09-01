using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_intarr_cs_d_intarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_intarr_cs_d_intarr_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\intarr_cs_d\\intarr_cs_d.cmd");
        }
    }
}
