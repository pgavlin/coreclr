using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_specific_class_static02_specific_class_static02_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_class_static02_specific_class_static02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_class_static02\\specific_class_static02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
