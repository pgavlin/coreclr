using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_dbgunsafe_4__speed_dbgunsafe_4_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_dbgunsafe_4__speed_dbgunsafe_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_dbgunsafe-4\\_speed_dbgunsafe-4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
