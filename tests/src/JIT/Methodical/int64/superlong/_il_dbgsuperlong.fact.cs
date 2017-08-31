using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__il_dbgsuperlong__il_dbgsuperlong_
    {
        [Fact]
        public void _int64_superlong__il_dbgsuperlong__il_dbgsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_il_dbgsuperlong\\_il_dbgsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
