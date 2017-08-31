using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_thiscall__dbgthisnull__dbgthisnull_
    {
        [Fact]
        public void _Invoke_thiscall__dbgthisnull__dbgthisnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\thiscall\\_dbgthisnull\\_dbgthisnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
