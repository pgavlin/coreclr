using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _unsafecsharp__relunsafe_4__relunsafe_4_
    {
        [OuterLoop]
        [Fact]
        public void _unsafecsharp__relunsafe_4__relunsafe_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\unsafecsharp\\_relunsafe-4\\_relunsafe-4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
