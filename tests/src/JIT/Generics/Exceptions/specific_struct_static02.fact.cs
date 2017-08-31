using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_specific_struct_static02_specific_struct_static02_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_struct_static02_specific_struct_static02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_struct_static02\\specific_struct_static02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
