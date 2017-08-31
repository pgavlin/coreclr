using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Classes_baseclass03_baseclass03_
    {
        [Fact]
        public void _Instantiation_Classes_baseclass03_baseclass03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Classes\\baseclass03\\baseclass03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
