using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_3__speed_dbgunsafe_3_
    {
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_3__speed_dbgunsafe_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-3\\_speed_dbgunsafe-3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
