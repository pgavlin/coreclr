using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_dbghan3_ctor__il_dbghan3_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_dbghan3_ctor__il_dbghan3_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_dbghan3_ctor\\_il_dbghan3_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
