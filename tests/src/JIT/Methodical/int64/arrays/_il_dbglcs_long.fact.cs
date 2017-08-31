using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_dbglcs_long__il_dbglcs_long_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__il_dbglcs_long__il_dbglcs_long_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_dbglcs_long\\_il_dbglcs_long.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
