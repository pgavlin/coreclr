using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Exceptions_specific_struct_instance01_specific_struct_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _Exceptions_specific_struct_instance01_specific_struct_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Exceptions\\specific_struct_instance01\\specific_struct_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
