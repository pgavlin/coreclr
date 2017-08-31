using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbggc_nested__speed_dbggc_nested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbggc_nested__speed_dbggc_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbggc_nested\\_speed_dbggc_nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
