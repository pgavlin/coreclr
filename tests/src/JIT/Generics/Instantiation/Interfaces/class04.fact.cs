using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Interfaces_class04_class04_
    {
        [Fact]
        public void _Instantiation_Interfaces_class04_class04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Interfaces\\class04\\class04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
