using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Classes_baseclass01_baseclass01_
    {
        [Fact]
        public void _Instantiation_Classes_baseclass01_baseclass01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Classes\\baseclass01\\baseclass01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
