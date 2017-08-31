using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_general_class_static01_general_class_static01_
    {
        [Fact]
        public void _Exceptions_general_class_static01_general_class_static01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\general_class_static01\\general_class_static01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
