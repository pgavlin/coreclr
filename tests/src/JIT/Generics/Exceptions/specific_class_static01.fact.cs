using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_specific_class_static01_specific_class_static01_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_class_static01_specific_class_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_class_static01\\specific_class_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
