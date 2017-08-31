using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_class01_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_class01_class01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\class01\\class01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
