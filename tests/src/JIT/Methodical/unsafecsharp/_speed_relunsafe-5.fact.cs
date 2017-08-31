using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_5__speed_relunsafe_5_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_relunsafe_5__speed_relunsafe_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-5\\_speed_relunsafe-5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
