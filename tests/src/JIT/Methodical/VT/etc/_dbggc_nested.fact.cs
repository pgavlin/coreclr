using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__dbggc_nested__dbggc_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbggc_nested__dbggc_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbggc_nested\\_dbggc_nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
