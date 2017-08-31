using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__il_rellivecall__il_rellivecall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__il_rellivecall__il_rellivecall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_il_rellivecall\\_il_rellivecall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
