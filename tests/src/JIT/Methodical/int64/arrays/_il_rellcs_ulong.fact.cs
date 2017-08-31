using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_rellcs_ulong__il_rellcs_ulong_
    {
        [Fact]
        public void _int64_arrays__il_rellcs_ulong__il_rellcs_ulong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_rellcs_ulong\\_il_rellcs_ulong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
