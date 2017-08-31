using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_2__speed_relunsafe_2_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__speed_relunsafe_2__speed_relunsafe_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-2\\_speed_relunsafe-2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
