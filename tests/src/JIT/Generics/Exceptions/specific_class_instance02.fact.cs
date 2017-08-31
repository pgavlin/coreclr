using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_specific_class_instance02_specific_class_instance02_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_class_instance02_specific_class_instance02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_class_instance02\\specific_class_instance02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
