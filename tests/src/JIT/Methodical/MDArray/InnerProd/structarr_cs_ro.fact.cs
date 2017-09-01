using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_structarr_cs_ro_structarr_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_structarr_cs_ro_structarr_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\structarr_cs_ro\\structarr_cs_ro.cmd");
        }
    }
}
