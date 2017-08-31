using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__speed_relsuperlong__speed_relsuperlong_
    {
        [Fact]
        public void _int64_superlong__speed_relsuperlong__speed_relsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_speed_relsuperlong\\_speed_relsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
