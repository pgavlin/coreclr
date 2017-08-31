using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Classes_baseclass02_baseclass02_
    {
        [Fact]
        public void _Instantiation_Classes_baseclass02_baseclass02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Classes\\baseclass02\\baseclass02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
