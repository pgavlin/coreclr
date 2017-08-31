using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relgc_nested__relgc_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relgc_nested__relgc_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relgc_nested\\_relgc_nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
