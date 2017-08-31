using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_1__speed_dbgunsafe_1_
    {
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_1__speed_dbgunsafe_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-1\\_speed_dbgunsafe-1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
