using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__speed_dbgsuperlong__speed_dbgsuperlong_
    {
        [Fact]
        public void _int64_superlong__speed_dbgsuperlong__speed_dbgsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_speed_dbgsuperlong\\_speed_dbgsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
