using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_structarr_cs_d_structarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_structarr_cs_d_structarr_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\structarr_cs_d\\structarr_cs_d.cmd");
        }
    }
}
