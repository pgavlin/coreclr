using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Typeof_objectBoxing_objectBoxing_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_objectBoxing_objectBoxing_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\objectBoxing\\objectBoxing.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
