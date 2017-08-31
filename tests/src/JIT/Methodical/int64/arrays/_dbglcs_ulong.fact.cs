using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__dbglcs_ulong__dbglcs_ulong_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__dbglcs_ulong__dbglcs_ulong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_dbglcs_ulong\\_dbglcs_ulong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
