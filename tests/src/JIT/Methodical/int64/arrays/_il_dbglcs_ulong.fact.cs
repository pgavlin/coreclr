using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_dbglcs_ulong__il_dbglcs_ulong_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__il_dbglcs_ulong__il_dbglcs_ulong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_dbglcs_ulong\\_il_dbglcs_ulong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
