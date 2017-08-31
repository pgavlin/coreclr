using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_class03_class03_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_class03_class03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\class03\\class03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
