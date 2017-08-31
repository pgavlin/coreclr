using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__rellcs_ulong__rellcs_ulong_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__rellcs_ulong__rellcs_ulong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_rellcs_ulong\\_rellcs_ulong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
