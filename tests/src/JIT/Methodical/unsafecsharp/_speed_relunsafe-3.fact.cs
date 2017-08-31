using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__speed_relunsafe_3__speed_relunsafe_3_
    {
        [Fact]
        public void _unsafecsharp__speed_relunsafe_3__speed_relunsafe_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_speed_relunsafe-3\\_speed_relunsafe-3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
