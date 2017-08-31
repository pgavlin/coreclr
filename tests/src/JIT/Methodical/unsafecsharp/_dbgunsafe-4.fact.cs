using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__dbgunsafe_4__dbgunsafe_4_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__dbgunsafe_4__dbgunsafe_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_dbgunsafe-4\\_dbgunsafe-4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
