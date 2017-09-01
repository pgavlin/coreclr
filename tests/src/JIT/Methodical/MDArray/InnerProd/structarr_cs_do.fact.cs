using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_InnerProd_structarr_cs_do_structarr_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_structarr_cs_do_structarr_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\structarr_cs_do\\structarr_cs_do.cmd");
        }
    }
}
