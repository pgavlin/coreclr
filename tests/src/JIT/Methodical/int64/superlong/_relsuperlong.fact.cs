using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_superlong__relsuperlong__relsuperlong_
    {
        [Fact]
        public void _int64_superlong__relsuperlong__relsuperlong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\superlong\\_relsuperlong\\_relsuperlong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
