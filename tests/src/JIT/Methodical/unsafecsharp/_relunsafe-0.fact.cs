using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__relunsafe_0__relunsafe_0_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__relunsafe_0__relunsafe_0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_relunsafe-0\\_relunsafe-0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
