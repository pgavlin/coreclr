using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _array_il__Arrayscomplex3__Arrayscomplex3_
    {
        [Fact]
        public void _array_il__Arrayscomplex3__Arrayscomplex3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\array-il\\_Arrayscomplex3\\_Arrayscomplex3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
