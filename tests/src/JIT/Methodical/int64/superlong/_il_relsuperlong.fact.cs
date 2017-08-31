using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__il_relsuperlong__il_relsuperlong_
    {
        [Fact]
        public void _int64_superlong__il_relsuperlong__il_relsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_il_relsuperlong\\_il_relsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
