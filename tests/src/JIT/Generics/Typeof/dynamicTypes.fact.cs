using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_dynamicTypes_dynamicTypes_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_dynamicTypes_dynamicTypes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\dynamicTypes\\dynamicTypes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
