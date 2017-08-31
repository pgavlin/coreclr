using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_4__speed_relunsafe_4_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_relunsafe_4__speed_relunsafe_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-4\\_speed_relunsafe-4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
