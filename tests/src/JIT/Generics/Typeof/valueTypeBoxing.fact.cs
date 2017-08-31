using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_valueTypeBoxing_valueTypeBoxing_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_valueTypeBoxing_valueTypeBoxing_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\valueTypeBoxing\\valueTypeBoxing.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
