using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_stringarr_cs_d_stringarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_stringarr_cs_d_stringarr_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\stringarr_cs_d\\stringarr_cs_d.cmd");
        }
    }
}
