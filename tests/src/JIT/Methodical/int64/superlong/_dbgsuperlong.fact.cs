using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__dbgsuperlong__dbgsuperlong_
    {
        [Fact]
        public void _int64_superlong__dbgsuperlong__dbgsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_dbgsuperlong\\_dbgsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
