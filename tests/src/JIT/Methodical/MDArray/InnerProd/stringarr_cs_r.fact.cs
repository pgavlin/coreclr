using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_stringarr_cs_r_stringarr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_stringarr_cs_r_stringarr_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\stringarr_cs_r\\stringarr_cs_r.cmd");
        }
    }
}
