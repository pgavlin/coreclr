using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_dbgnested__il_dbgnested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_dbgnested__il_dbgnested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_dbgnested\\_il_dbgnested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
