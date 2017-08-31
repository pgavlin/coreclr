using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_2__speed_dbgunsafe_2_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_2__speed_dbgunsafe_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-2\\_speed_dbgunsafe-2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
