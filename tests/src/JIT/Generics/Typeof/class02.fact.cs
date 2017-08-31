using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_class02_class02_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_class02_class02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\class02\\class02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
