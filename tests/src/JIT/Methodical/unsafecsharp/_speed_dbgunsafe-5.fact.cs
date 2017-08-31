using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_5__speed_dbgunsafe_5_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_5__speed_dbgunsafe_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-5\\_speed_dbgunsafe-5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
