using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__dbglcs_long__dbglcs_long_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__dbglcs_long__dbglcs_long_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_dbglcs_long\\_dbglcs_long.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
