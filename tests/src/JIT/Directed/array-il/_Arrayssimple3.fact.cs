using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _array_il__Arrayssimple3__Arrayssimple3_
    {
        [OuterLoop]
        [Fact]
        public void _array_il__Arrayssimple3__Arrayssimple3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\array-il\\_Arrayssimple3\\_Arrayssimple3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
