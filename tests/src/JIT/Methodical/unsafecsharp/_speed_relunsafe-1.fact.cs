using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_1__speed_relunsafe_1_
    {
        [Fact]
        public void _unsafecsharp__speed_relunsafe_1__speed_relunsafe_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-1\\_speed_relunsafe-1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
