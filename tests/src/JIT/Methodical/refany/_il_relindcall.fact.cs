using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relindcall__il_relindcall_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relindcall__il_relindcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relindcall\\_il_relindcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
