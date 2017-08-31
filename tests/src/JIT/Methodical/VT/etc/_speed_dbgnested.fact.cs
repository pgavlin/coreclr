using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbgnested__speed_dbgnested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbgnested__speed_dbgnested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbgnested\\_speed_dbgnested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
