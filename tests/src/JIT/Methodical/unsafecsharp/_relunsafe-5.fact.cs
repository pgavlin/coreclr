using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__relunsafe_5__relunsafe_5_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__relunsafe_5__relunsafe_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_relunsafe-5\\_relunsafe-5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
