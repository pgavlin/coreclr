using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_6__speed_dbgunsafe_6_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_6__speed_dbgunsafe_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-6\\_speed_dbgunsafe-6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
