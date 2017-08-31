using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Classes_baseclass04_baseclass04_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_Classes_baseclass04_baseclass04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Classes\\baseclass04\\baseclass04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
