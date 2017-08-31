using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_thiscall__speed_dbgthisnull__speed_dbgthisnull_
    {
        [Fact]
        public void _Invoke_thiscall__speed_dbgthisnull__speed_dbgthisnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\thiscall\\_speed_dbgthisnull\\_speed_dbgthisnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
