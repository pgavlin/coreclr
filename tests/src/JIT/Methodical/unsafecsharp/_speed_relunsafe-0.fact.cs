using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_0__speed_relunsafe_0_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_relunsafe_0__speed_relunsafe_0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-0\\_speed_relunsafe-0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
