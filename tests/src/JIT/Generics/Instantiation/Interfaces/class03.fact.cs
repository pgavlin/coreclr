using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Interfaces_class03_class03_
    {
        [Fact]
        public void _Instantiation_Interfaces_class03_class03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Interfaces\\class03\\class03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
